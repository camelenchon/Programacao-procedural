using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a altura do retangulo");
        int alturaRetangulo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a base do triangulo");
        int baseRetangulo = int.Parse(Console.ReadLine());

        for ( int linha = 0; linha < alturaRetangulo; linha++)
        {
            for (int coluna = 0; coluna < baseRetangulo; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

    }
}

