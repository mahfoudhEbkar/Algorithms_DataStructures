using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructures
{
    class InsertionSortAlgorithm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr = { 7, 8, 4, 6, 2, 1 };
            int[] arr = { 4, 3, 5, 1, 2, 0 };
            Console.WriteLine("Array before sort: 4, 3, 5, 1, 2, 0");
            //Console.WriteLine("Array before sort: 7,8,4,6,2,1");


            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > temp)
                {
                    arr[j] = arr[j - 1];
                    foreach (int val in arr)
                    {
                        Console.Write(val + ",");


                    }

                    Console.WriteLine("time i " + i + "  time j " + j);
                    j--;
                }
                arr[j] = temp;
            }
            Console.WriteLine("Array After sort: ");
            foreach (int val in arr)
            {
                Console.Write(val + ",");
            }
            Console.ReadLine();
        }
    }
}
