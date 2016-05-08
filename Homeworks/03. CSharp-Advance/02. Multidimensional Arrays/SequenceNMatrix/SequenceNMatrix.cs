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

            count = 1;
        }

        //check if there are equal elements in columns
        for (int col = 0; col < m; col++)
        {
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
        
            count = 1;
        }

        //check if there are equal elements in left to right diagonal
        for (int row = 0, col = 0; row < n - 1 && col < m - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
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
        count = 1;


        //check if there are equal elements in diagonal - right to left 
        for (int row = 0, col = 0; row < n - 1 && col > 0; row++, col--)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
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
        
        count = 1;

        Console.WriteLine(maxCount);
    }
}

