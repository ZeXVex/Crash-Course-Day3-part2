using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, n, sum = 0;


            Console.WriteLine("Find sum of all elements of array:");
            Console.WriteLine("--------------------------------------");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Sum of all elements stored in the array is: {0}\n\n", sum);

            Console.ReadLine();
        }
    }
}
