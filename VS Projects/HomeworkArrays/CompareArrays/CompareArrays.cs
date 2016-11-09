using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int[] numbers = new int[A];
            int[] cifri = new int[A];
            
            for (int i = 0; i < numbers.Length; ++i)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                cifri[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < A; j++)
            {
                string B = Convert.ToString(numbers[j]);
                string C = Convert.ToString(cifri[j]);
                if (B == C)
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }
            }
        }
    }
}
