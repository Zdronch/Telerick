using System;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static void Main()
        {
            string[] NM = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(NM[0]);
            int cols = int.Parse(NM[1]);
            int[,] matrix = new int[rows, cols];

            int maxSum = int.MinValue;
            int sum = 1;

            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(currentRowNumbersAsStrings[col]);
                }
            }
            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1] || matrix[r, c] == matrix[r + 1, c])
                    {
                        sum++;
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
