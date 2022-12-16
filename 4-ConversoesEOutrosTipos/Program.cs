using System;
class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int) salario;
        Console.WriteLine(salarioInteiro);

        long x; //long variavel de 64bits
        x = 2000000000000000000;
        Console.WriteLine(x);

        short y;
        y = 15000;
        Console.WriteLine(y);

        float altura;
        altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle <Enter> para fechar...");
        Console.ReadLine();

    }
}

