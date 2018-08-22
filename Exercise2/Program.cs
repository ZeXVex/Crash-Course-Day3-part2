using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];

            Console.WriteLine("Read n number of values in an array and display it in reverse order: ");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Input the number of elements for the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} number of elements in the array: ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe values store into the array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.WriteLine("\n\nThe values store into the array in reverse are: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
