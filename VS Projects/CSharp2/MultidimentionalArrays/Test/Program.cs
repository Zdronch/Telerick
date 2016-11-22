using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string[] NM = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(NM[0]);
            int cols = int.Parse(NM[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(currentRowNumbersAsStrings[col]);
                }
            }
            bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            int bestCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!calculated[row, col])
                    {
                        int count = DepthFirstSearch(matrix, row, col, calculated);
                        if (bestCount < count)
                        {
                            bestCount = count;
                        }
                    }

                }
            }
            Console.WriteLine(bestCount);
        }

        static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
        {
            int result = 1;
            calc[row, col] = true;
            if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
            {
                result += DepthFirstSearch(array, row - 1, col, calc);
            }
            if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
            {
                result += DepthFirstSearch(array, row + 1, col, calc);
            }
            if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
            {
                result += DepthFirstSearch(array, row, col - 1, calc);
            }
            if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
            {
                result += DepthFirstSearch(array, row, col + 1, calc);
            }
            return result;
        }
    }
}