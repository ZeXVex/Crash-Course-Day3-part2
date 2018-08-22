using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.WriteLine("Read and print number into array: ");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Insert number into array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadLine();
        }
    }
}
