using System;

namespace DesafioMultiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("S E P A R A D O R");

            //outra forma
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
