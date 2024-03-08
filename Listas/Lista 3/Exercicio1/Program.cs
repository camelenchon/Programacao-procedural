using System;


class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_DE_HABITANTES = 20;
        double somatorioDeFilhos = 0;
        double somatorioSalario = 0;
        double maiorSalario = 0;
    
        for (int contador = 1; contador <= NUMERO_DE_HABITANTES; contador ++)
        {
            System.Console.WriteLine("Qual o seu salario?");
            double salarioAtual = double.Parse(Console.ReadLine());
            
            somatorioSalario = somatorioSalario + salarioAtual;

            System.Console.WriteLine("Quantos filhos você tem");
            double filhosPorHabitante = double.Parse(Console.ReadLine());

            somatorioDeFilhos = somatorioDeFilhos + filhosPorHabitante;

            if (salarioAtual > maiorSalario)
            {
                maiorSalario = salarioAtual;
            }
        }    
        somatorioSalario = somatorioSalario / NUMERO_DE_HABITANTES;
        somatorioDeFilhos = somatorioDeFilhos / NUMERO_DE_HABITANTES;
        
        System.Console.WriteLine("A media de salario da população eh de: " + Math.Round(somatorioSalario, 2));
        System.Console.WriteLine(" a media de numero de filhos por habitante eh de: " + somatorioDeFilhos);
        System.Console.WriteLine("O maior salario eh de: R$ " + Math.Round(maiorSalario, 2));
    }
}