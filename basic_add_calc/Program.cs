using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_add_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Input: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second Number Input: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
