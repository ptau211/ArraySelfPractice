using System;

namespace ArraySelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an array with size 6
            int[] arr = new int[10];

            //accessing array values using loop
            //Here it will display the default values
            //as we are not assigning any values
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int a = 0;
            //Here we are assigning values to array using for loop
            for (int i = 0; i < 10; i++)
            {
                a += 10;
                arr[i] = a;
            }
            //accessing array values using foreach loop
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
