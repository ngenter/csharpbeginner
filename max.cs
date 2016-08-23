using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            var max = (input1 > input2) ? input1 : input2;

            Console.WriteLine("Max is: " + max);


        }   
       
    }
}
