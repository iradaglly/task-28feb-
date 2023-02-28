using System;

namespace arrays_objects_task1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers ={2, 3, 6, 7, 9};
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    counter += 1;
                    sum += numbers[i];
            }
            }

            Console.WriteLine(sum/counter);
        }
    }
}