﻿using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string card = input;

            switch (card)
            {
                case "2":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "3":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "4":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "5":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "6":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "7":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "8":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "9":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "10":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "J":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "Q":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "K":
                    Console.WriteLine("yes {0}", card);
                    break;
                case "A":
                    Console.WriteLine("yes {0}", card);
                    break;
                default:
                    Console.WriteLine("no {0}", card);
                    break;
            }
        }
    }
}
