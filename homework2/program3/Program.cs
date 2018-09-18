using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 1;
            Console.Write("2-100内的素数是 " + 2);
            for (int i = 3; i < 101; i += 2)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == i - 1)
                    {
                        Console.Write(" " + i);
                        n++;
                        if (n % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }

                }
            }
            Console.WriteLine();
        }
    }
}
