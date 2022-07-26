using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_odd_number_check
{
    internal class Program
    {
       class check
        {
            public void Even(int r)
            {
                if (r % 2 == 0)
                {
                    Console.WriteLine($"The {r} entered is even number");
                }
                else
                {
                    Console.WriteLine("This is not an even number");
                }
            }
            public void odd(int h)
            {
                if (h % 2 != 0)
                {
                    Console.WriteLine($"The {h} entered is odd number");
                }
                else
                {
                    Console.WriteLine("This is not an odd number");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select option: ");
            Console.WriteLine("1. even ");
            Console.WriteLine("2. odd ");
            int source = Convert.ToInt32(Console.ReadLine());
            
            check input = new check();
            Console.WriteLine("");
            if (source == 1)
            {
                Console.WriteLine("Enter number");
                int r = Convert.ToInt32(Console.ReadLine());
                input.Even(r);
            }
            else if (source == 2)
            {
                Console.WriteLine("Enter number");
                int h = Convert.ToInt32(Console.ReadLine());
                input.odd(h);
            }
        }
    }
}
