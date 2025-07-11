using System;

namespace MyFirstApplication
{

    public class Display
    {
        public static void DisplayElements<Coisas>(Coisas[] array)
        {
            foreach (Coisas item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}