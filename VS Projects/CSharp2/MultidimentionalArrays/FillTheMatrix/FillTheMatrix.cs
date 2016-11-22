using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_FillsAndPrintsMatrix
{
    class FillsAndPrintsMatrix
    {
        static int[,] fillMatrixA(int n)
        {
            int startCount = 1;
            int[,] matrix = new int[n, n];
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[cols, rows] = startCount++;
                }
            }
            return matrix;
        }
        static int[,] fillMatrixB(int n)
        {
            int[,] matrix = new int[n, n];
            int startCount = 1;
            for (int rows = 0; rows < n; rows++)
            {
                if (rows % 2 == 0)
                {
                    for (int cols = 0; cols < n; cols++)
                    {
                        matrix[cols, rows] = startCount++;
                    }
                }
                else
                {
                    for (int cols = n - 1; cols >= 0; cols--)
                    {
                        matrix[cols, rows] = startCount++;
                    }
                }
            }
            return matrix;
        }

        static int[,] fillMatrixC(int n)
        {
            int[,] matrix = new int[n, n];
            int rows = 0;
            int cols = 0;
            int startCount = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = startCount++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = startCount++;
                }
            }
            return matrix;
        }
        static int[,] fillMatrixD(int n)
        {
            int[,] result = new int[n, n];
            int numberToAdd = 1;
            int globalCounter = n;
            int tempValue = -n;
            int sum = -1;

            do
            {
                tempValue = -1 * tempValue / n;
                for (int i = 0; i < globalCounter; i++)
                {
                    sum += tempValue;
                    result[sum / n, sum % n] = numberToAdd;
                    numberToAdd++;
                }
                tempValue *= n;
                globalCounter--;
                for (int i = 0; i < globalCounter; i++)
                {
                    sum += tempValue;
                    result[sum / n, sum % n] = numberToAdd;
                    numberToAdd++;
                }
            } while (globalCounter > 0);

            return result;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int p = 0; p < matrix.GetLength(1); p++)
                {
                    Console.Write(matrix[i, p]);
                    if (p + 1 == matrix.GetLength(0))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char matrixChoice = (char)(Console.Read());

            if (char.ToUpper(matrixChoice) == 'A')
            {
                int[,] a = fillMatrixA(n);
                PrintMatrix(a);
            }

            if (char.ToUpper(matrixChoice) == 'B')
            {
                int[,] a = fillMatrixB(n);
                PrintMatrix(a);
            }

            if (char.ToUpper(matrixChoice) == 'C')
            {
                int[,] a = fillMatrixC(n);
                PrintMatrix(a);
            }

            if (char.ToUpper(matrixChoice) == 'D')
            {
                int[,] a = fillMatrixD(n);
                PrintMatrix(a);
            }

        }
    }
}

//using System;

//namespace FillTheMatrix
//{
//    class FillTheMatrix
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            char pattern = (char)Console.Read();

//            int[,] matrix = new int[n,n];
//            int num = 1;


//            if (char.ToUpper(pattern) == 'A')
//            {
//                for (int col = 0; col < n; col++)
//                {
//                    for (int row = 0; row < n; row++)
//                    {
//                        matrix[row, col] = num;
//                        num++;
//                    }
//                }
//            }
//            else if (char.ToUpper(pattern) == 'B')
//            {
//                for (int col = 0; col < n; col++)
//                {
//                    if (col % 2 == 0)
//                    {
//                        for (int row = 0; row < n; row++)
//                        {
//                            matrix[row, col] = num;
//                            num++;
//                        }
//                    }
//                    else
//                    {
//                        for (int row = n - 1; row >= 0; row--)
//                        {
//                            matrix[row, col] = num;
//                            num++;
//                        }
//                    }
//                }
//            }
//            else if (char.ToUpper(pattern) == 'C')
//            {
//                for (int row = 0; row < n; row++)
//                {
//                    for (int col = 0; col < n; col++)
//                    {
//                        if (row == n - col - 1)
//                        {
//                            num += matrix[row, col];
//                        }
//                    }
//                }
//            }

//            for (int row = 0; row < n; row++)
//            {
//                for (int col = 0; col < n; col++)
//                {

//                    Console.Write(string.Join(", ", matrix[row, col]));
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
