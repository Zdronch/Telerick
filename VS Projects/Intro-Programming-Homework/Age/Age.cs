using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            String MyBD = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(MyBD);
            DateTime Today = DateTime.Now;
            TimeSpan span = Today.Subtract(dt);
            int years = (int)(span.Days / 365.25);
            int nty = 10;
            Console.WriteLine(years);
            Console.WriteLine(years + nty);
        }
    }
}
