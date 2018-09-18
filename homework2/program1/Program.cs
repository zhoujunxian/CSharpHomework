using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static bool isPrime(int n)
        {
            int i;
            for (i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    break;
                }
            }
            if (i >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number :");
            string s = Console.ReadLine();
            int input = int.Parse(s);
            int temp = input;
            Console.WriteLine(input + "的质因数是:");
            for (int i = 2; i <= input; i++)
            {
                if (!isPrime(i))
                {
                    continue;
                }
                while (true)
                {
                    if (temp % i == 0)
                    {
                        temp = temp / i;
                        Console.Write(i + " ");
                    }
                    else
                    {
                        break;
                    }
                }
                if (temp == 1)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
