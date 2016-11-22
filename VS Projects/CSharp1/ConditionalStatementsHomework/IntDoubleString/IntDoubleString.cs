using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string a = Console.ReadLine();

            switch (a)
            {
                case "integer":
                    int Integer = int.Parse(Console.ReadLine());
                    Console.WriteLine(Integer + 1);
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:0.00}", real + 1);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                default:
                    break;
            }

        }
    }
}
