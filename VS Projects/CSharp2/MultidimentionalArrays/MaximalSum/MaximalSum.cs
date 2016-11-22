using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string[] NM = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(NM[0]);
            int cols = int.Parse(NM[1]);
            int[,] matrix = new int[rows, cols];

            int maxSum = int.MinValue;
            //int maxRow = 0;    Prints the largest sector 3x3
            //int maxCol = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(currentRowNumbersAsStrings[col]);
                }
            }
            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                              matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                              matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        //maxRow = r;                  Prints the largest sector 3x3
                        //maxCol = c;
                    }
                }
            }
            Console.WriteLine(maxSum);
            //for (int r = maxRow; r < maxRow + 3; r++)             Prints the largest sector 3x3
            //{
            //    for (int c = maxCol; c < maxCol + 3; c++)
            //    {
            //        Console.Write("{0} ", matrix[r, c]);
            //    }
            //    Console.WriteLine();
        }
    }
}