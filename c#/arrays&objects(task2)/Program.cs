using System;

namespace arrays_objects_task2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 22, 15, 512, 61, 821 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 99)
                { 
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}