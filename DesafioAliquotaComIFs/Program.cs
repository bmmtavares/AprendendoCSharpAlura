using System;

namespace DesafioAliquotaComIFs
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("IR é de 7.5%");
                Console.WriteLine("pode deduzir na declaração o valor de R$ 142");
            }

            if (salario >= 2800.01 && salario <= 3751)
            {
                Console.WriteLine("IR é de 15%");
                Console.WriteLine("pode deduzir na declaração o valor de R$ 350");
            }

            if (salario >= 3751.01 && salario <= 4664)
            {
                Console.WriteLine("IR é de 22.5%");
                Console.WriteLine("pode deduzir na declaração o valor de R$ 636");
            }
        }
    }
}
