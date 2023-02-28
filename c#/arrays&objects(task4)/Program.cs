using System;

namespace arrays_objects_task4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string [] names ={"Aydan", "Fidan", "Nuray", "Aysel"};
            int counter = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith("A")) 
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }
    }
}