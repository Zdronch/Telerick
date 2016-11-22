using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int[] numbers = new int[A];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
                Console.WriteLine(numbers[i]*5);
            }
        }
    }
}
