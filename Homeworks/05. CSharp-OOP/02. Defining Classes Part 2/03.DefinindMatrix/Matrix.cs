namespace _03.DefinindMatrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        // problem 8
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[this.rows, this.cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Rows should not be less than 1!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Columns should not be less than 1!");
                }

                this.cols = value;
            }
        }

        // problem 9
        public T this[int rowIndex, int colIndex]
        {
            get
            {
                if (rowIndex > this.rows || rowIndex < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index {0}!", rowIndex));
                }

                if (colIndex > this.cols || colIndex < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index {0}!", colIndex));
                }

                T result = this.matrix[rowIndex, colIndex];

                return result;
            }

            set
            {
                this.matrix[rowIndex, colIndex] = value;
            }
        }

        // problem 10
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Number of rows and columns of matrixes should be equal!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Number of rows and columns of matrixes should be equal!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new ArgumentException("These matrices cannot be multiplied");
            }

            Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            T result = (dynamic)0;

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    for (int k = 0; k < firstMatrix.Cols; k++)
                    {
                        result += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                    }

                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool nonZeroElement = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElement = false;
                    }
                }
            }

            return nonZeroElement;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool nonZeroElement = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        nonZeroElement = false;
                    }
                }
            }

            return nonZeroElement;
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    result.Append(string.Format("{0,4}", this.matrix[i, j]));
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
