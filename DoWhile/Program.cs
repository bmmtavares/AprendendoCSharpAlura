using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Do While!");

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }
}
