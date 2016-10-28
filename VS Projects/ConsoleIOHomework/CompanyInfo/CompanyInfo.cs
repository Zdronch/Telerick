using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
          
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string i = Console.ReadLine();

            Console.WriteLine(a);
            Console.WriteLine("Address: " + b);
            Console.WriteLine("Tel. " + c);
            Console.WriteLine((d == "")? "Fax: (no fax)" : "Fax: " + d);
            Console.WriteLine("Web site: " + e);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", f, g, h, i);
        }
    }
}
