using System;
using System.Net.Http;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;
        //rendimento de 0.5% ao mes
        //mes 1
        //investimento = investimento + investimento * 0.005;
        //mes 2
        //investimento = investimento + investimento * 0.005;
        //mes 3
        //investimento = investimento + investimento * 0.005;
        //Console.WriteLine(investimento);

        int mes=1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine($"No mês {mes} você tem R$ { investimento}");

            mes += 1;
        }

        Console.WriteLine("Tecle <Enter> para fechar...");
        Console.ReadLine();
    }
}

