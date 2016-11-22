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
            string[,] matrix = new string[rows, cols];

            int currentLenght = 1;
            int bestLenght = int.MinValue;
            string bestValue = String.Empty;

            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRowNumbersAsStrings[col];
                }
            }
            //for (int r = 0; r < matrix.GetLength(0); r++)
            //{
            //    for (int c = 0; c < matrix.GetLength(1); c++)
            //    {
            //        Console.Write("{0} ", matrix[r, c]);
            //    }
            //    Console.WriteLine();
            //}
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    if (matrix[r, c] == matrix[r, c + 1])
                    {
                        currentLenght++;
                    }
                    if (bestLenght < currentLenght)
                    {
                        bestLenght = currentLenght;
                    }
                }
            }
            Console.WriteLine(bestValue);
        }
    }
}


//using System;
//using System.Collections.Generic;

//class SequenceInMatrix
//{
//    static void Main()
//    {
//        List<List<string>> matrix = new List<List<string>>();

//        string currentRowContents = Console.ReadLine();
//        string[] currentRowTokens;
//        for (int row = 0; !String.IsNullOrEmpty(currentRowContents); row++)
//        {
//            matrix.Add(new List<string>());
//            currentRowTokens = currentRowContents.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            for (int col = 0; col < currentRowTokens.Length; col++)
//            {
//                matrix[row].Add(currentRowTokens[col]);
//            }

//            currentRowContents = Console.ReadLine();
//        }

//        int currentLength = 1;
//        int bestLength = int.MinValue;
//        for (int row = 0; row < matrix.Count; row++)
//        {
//            for (int col = 0; col < matrix[row].Count; col++)
//            {
//                currentLength = CheckVertical(matrix, row, col, matrix[row][col]);
//                if (currentLength > bestLength)
//                {
//                    bestLength = currentLength;
//                }
//                currentLength = CheckHorizontal(matrix, row, col, matrix[row][col]);
//                if (currentLength > bestLength)
//                {
//                    bestLength = currentLength;
//                }
//                currentLength = CheckDiagonal(matrix, row, col, matrix[row][col]);
//                if (currentLength > bestLength)
//                {
//                    bestLength = currentLength;
//                }
//            }
//        }
//        Console.WriteLine(bestLength);
//    }

//    private static int CheckDiagonal(List<List<string>> matrix, int row, int col, string currentValue)
//    {
//        int currentLength = 1;
//        for (int i = row, j = col; i < matrix.Count && j < matrix[row].Count; i++, j++)
//        {
//            if (i + 1 < matrix.Count && j + 1 < matrix[i + 1].Count && matrix[i + 1][j + 1].Equals(currentValue))
//            {
//                currentLength++;
//            }
//            else
//            {
//                break;
//            }
//        }
//        return currentLength;
//    }

//    private static int CheckHorizontal(List<List<string>> matrix, int row, int col, string currentValue)
//    {
//        int currentLength = 1;
//        for (int i = col; i < matrix[row].Count; i++)
//        {
//            if (i + 1 < matrix[row].Count && matrix[row][i + 1].Equals(currentValue))
//            {
//                currentLength++;
//            }
//            else
//            {
//                break;
//            }
//        }
//        return currentLength;
//    }

//    private static int CheckVertical(List<List<string>> matrix, int row, int col, string currentValue)
//    {
//        int currentLength = 1;
//        for (int i = row; i < matrix.Count; i++)
//        {
//            if (i + 1 < matrix.Count && matrix[i + 1][col].Equals(currentValue))
//            {
//                currentLength++;
//            }
//            else
//            {
//                break;
//            }
//        }
//        return currentLength;
//    }
//}
