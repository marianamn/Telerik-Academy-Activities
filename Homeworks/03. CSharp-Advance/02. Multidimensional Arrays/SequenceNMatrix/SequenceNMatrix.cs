using System;

class SequenceNMatrix
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            string[] rowsNum = Console.ReadLine().Split(' ');

            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = rowsNum[col];
            }
        }

        int count = 1;
        int maxCount = 1;

        //check if there are equal elements in rows
        for (int row = 0; row < n; row++)
        {
            count = 1;

            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
        }

        //check if there are equal elements in columns
        for (int col = 0; col < m; col++)
        {
            count = 1;

            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
        
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
        }

        // Check Diagonals
        // Diagonal Left 
        for (int Col = 1; Col < m; Col++)
        {
            count = 1;

            for (int curMod = 1; curMod <= Math.Min(Col, n - 1); curMod++)
            {
                if (matrix[0 + curMod,Col - curMod] == matrix[0 + (curMod - 1),Col - (curMod - 1)])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        for (int Row = 1; Row < n; Row++)
        {
            count = 1;

            for (int curMod = 1; curMod <= Math.Min(n - 1 - Row - 1, m - 2); curMod++)
            {
                if (matrix[Row + curMod,(m - 1) - curMod] == matrix[Row + (curMod + 1),(m - 1) - (curMod + 1)])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        // Diagonal Right
        for (int Row = n - 2;Row >= 0;Row--)
        {
            count = 1;

            for (int curMod = 1; curMod <= Math.Min(n - Row - 1, m - 1);curMod++)
            {
                if (matrix[Row + curMod,0 + curMod] == matrix[Row + (curMod - 1),0 + (curMod - 1)])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        // Top Right
        for (int Row = 1; Row < n - 1; Row++)
        {
            count = 1;

            for (int curMod = 1; curMod <= Math.Min(Row - 1, m - 1); curMod++)
            {
                if (matrix[Row - curMod,(m - 1) - curMod] == matrix[Row - (curMod - 1),(m - 1) - (curMod - 1)])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
            }
        }

        Console.WriteLine(maxCount);
    }
}

