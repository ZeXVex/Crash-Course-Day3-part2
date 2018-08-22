using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;


            Console.WriteLine("Copy the elements one array into another array:");
            Console.WriteLine("----------------------------------------------------");

            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array: ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("The elements stored in the first array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            
            Console.WriteLine("\nThe elements copied into the second array are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.ReadLine();
        }
    }
}
