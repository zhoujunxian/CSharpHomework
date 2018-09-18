using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 86, 99, 61, 18, 69, 48, 14, 23, 76 };
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
                sum += i;
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine("The max number of the array is " + max);
            Console.WriteLine("The min number of the array is " + min);
            Console.WriteLine("The sum of the array is " + sum);
            Console.WriteLine("The average value of the array is " + average);
        }
    }
}
