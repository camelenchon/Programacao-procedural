using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("QUal a nota do primeiro bimestre?");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a nota do segundo bimetre?");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine ("Qual a nota do terceiro bimestre?");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a nota do quarto bimestre?");
        double nota4 = double.Parse(Console.ReadLine());

        double resultado = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.WriteLine("A média do aluno é" + resultado);

    }
}