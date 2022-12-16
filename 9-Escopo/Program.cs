using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeJoao = 16;
        int qdtPessoas = 2;

        bool acompanahdo = qdtPessoas > 1;

        string textoAdicional;
        if(acompanahdo == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || acompanahdo)
        {
            Console.WriteLine(textoAdicional);
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

