using System;

namespace demo_week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Setter = 0;
            int[] numbers = {15, 68, 4, 19, 99, 52, 53 ,36, 74, 1, 85 };
            do
            {
                if (numbers[Setter] % 2 != 0)
                {
                    Console.Write(numbers[Setter] + " ");
                }
                Setter++;
            }

            while (11 > Setter);
            Setter = 0;
            Console.WriteLine();
            do
            {
                if (numbers[Setter] % 2 == 0)
                {
                    Console.Write(numbers[Setter] + " ");
                }

                Setter++;
            }

            while (11 > Setter);
            Console.WriteLine();
            Console.Read();
        }
    }
}