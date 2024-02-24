using System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Qual a área da base do triângulo?");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a altura do triangulo?");
        double alturaDoTriangulo = double.Parse(Console.ReadLine());
        
        double areaDoTriangulo = baseTriangulo * alturaDoTriangulo /2;   
        Console.WriteLine("A area do triangulo eh maior que 20?" + (areaDoTriangulo > 20));

    
    }
}