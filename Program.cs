using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_odd_number_check
{
    internal class Program
    {
        static void Evennumber(int number)
        {
            if (number % 2 == 0)
            {
               Console.WriteLine($"The {number} entered is even number");
            }
            else
            {
               Console.WriteLine($"The {number} entered is odd number");
            }
            return;
        }
          
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Evennumber(number);
            Console.WriteLine("");
        }
    }
}
