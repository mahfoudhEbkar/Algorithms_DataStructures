using System;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] nums = { 5, 10, 3, 2, 4 }; ;

            Console.WriteLine("Before: 5, 10, 3, 2, 4");

            bool swapped;
            int j = 0;
            int k = 0;
            do
            {
                swapped = false;
                
                for (var i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        var temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                        swapped = true;
                    }
                    k++;
                    foreach (int val in nums)
                    {
                        Console.Write(val + ",");


                    }
                    Console.WriteLine("  time j " + j + "  time i " + i);

                }
                j++; 
                Console.Write("\n\non loop number: "+j+":  ");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write("{0}, ", nums[i]);
                }
            } while (swapped);


            Console.Write("\n After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.WriteLine("\n  K : " + k);
            Console.ReadLine();
        }
    }
}
