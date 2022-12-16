using System;
using System.Net.Http;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine($"No mês {mes} você tem R$ { investimento}");
        }

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine($"No mês {mes} você tem R$ { investimento}");

            mes += 1;
        }
        */

        Console.WriteLine("Tecle <Enter> para fechar...");
        Console.ReadLine();
    }
}

