using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int qdtPessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (qdtPessoas > 1)
            {
                Console.WriteLine("Ele está acompanahdo, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

        }


        Console.WriteLine("Tecle <Enter> para fechar...");
        Console.ReadLine();
    }
}

