using System;

namespace SwitchMeses
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 13;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("o mês é Janeiro");
                    break;
                case 2:
                    Console.WriteLine("o mês é Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("o mês é Março");
                    break;
                case 4:
                    Console.WriteLine("o mês é Abril");
                    break;
                case 5:
                    Console.WriteLine("o mês é Maio");
                    break;
                case 6:
                    Console.WriteLine("o mês é Junho");
                    break;
                case 7:
                    Console.WriteLine("o mês é Julho");
                    break;
                case 8:
                    Console.WriteLine("o mês é Agosto");
                    break;
                case 9:
                    Console.WriteLine("o mês é Setembro");
                    break;
                case 10:
                    Console.WriteLine("o mês é Outubro");
                    break;
                case 11:
                    Console.WriteLine("o mês é Novembro");
                    break;
                case 12:
                    Console.WriteLine("o mês é Dezembro");
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
