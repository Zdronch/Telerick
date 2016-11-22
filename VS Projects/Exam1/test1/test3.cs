using System;

namespace test1
{
    class test3
    {
        static void Main()
        {
            int D = int.Parse(Console.ReadLine());
            int pages = 0;

            for (int i = 1; D != 0; i++)
            {
                pages++;
                D -= i.ToString().Length;
                
            }
            Console.WriteLine(pages);
        }
    }
}
