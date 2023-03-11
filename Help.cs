using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._04
{
    internal class Help
    {
        public static int IncludetInt()
        {
            int number;
            l1:
           
             Console.Write("Eded daxil edin: ");
             if (!int.TryParse(Console.ReadLine(), out number))
             {
                Console.WriteLine("Yalniz eded daxil edin");
                goto l1;

             }
                          
            Console.WriteLine(number);
            return number;
            
        }
        public static int IntAltireqemli()
        {
            int number;
        l1:
            Console.Write("Eded daxil edin: ");

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Yalniz eded daxil edin");
                goto l1;
            }

            if (number < 100000 || number >= 1000000)
            {
                Console.WriteLine("Alti reqemli eded yazin");
                goto l1;

            }
            return number;
        }
    }
}
