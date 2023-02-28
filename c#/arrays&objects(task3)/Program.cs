using System;

namespace arrays_objects_task3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 8, 12, 32, 2, 15 };
            int max = numbers[0];
            int min = numbers[0];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];

                }
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine((max + min) / 2);
        }
    }
}