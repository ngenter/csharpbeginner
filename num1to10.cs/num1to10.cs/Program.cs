using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num1to10.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10: ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
                Console.WriteLine("That number is valid");
            else
                Console.WriteLine("That number is invalid");
        }
    }
}
