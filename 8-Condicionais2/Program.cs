using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais2");

        int idadeJoao = 16;
        int qdtPessoas = 2;

        bool acompanahdo = qdtPessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanahdo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
        Console.WriteLine("Tecle <Enter> para fechar...");
        Console.ReadLine();
    }
}

