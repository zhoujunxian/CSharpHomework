using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratice
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = "";
            double number1, number2;
            Console.WriteLine("Please Enter the number1 :");
            s = Console.ReadLine();
            number1 = double.Parse(s);
            Console.WriteLine("Please Enter the number2 :");
            s = Console.ReadLine();
            number2 = double.Parse(s);
            double number3 = number1 * number2;
            Console.WriteLine("number1 × number2 = " + number3);
        }

    }
}
