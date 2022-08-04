using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Or__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Enter 1 word");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter 2 word");            
            int b = Convert.ToInt32(Console.ReadLine()); 
            

            int sym;


            Console.WriteLine("Enter sumvol  ");
            Console.WriteLine("D = + and M = -");


            ConsoleKey vod = Console.ReadKey().Key;


            if (vod == ConsoleKey.D)
            {

                sym = a + b;
                Console.WriteLine();
                Console.WriteLine(sym);
            }


            if (vod == ConsoleKey.M)
            {
                sym = a - b;
                Console.WriteLine();
                Console.WriteLine(sym);
                
            }


        }
    }
}
