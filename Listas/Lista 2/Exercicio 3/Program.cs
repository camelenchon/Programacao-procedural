using System;
using System.Security.AccessControl;

// Você deve criar um programa para ajudar a babá a lembrar a rotina de Filomena e Joselito. Seu programa deve receber o nome de uma das crianças, armazenar em uma variável, verificar se o nome recebido é o de Filomena ou o de Joselito e, por fim, exibir a rotina da criança correspondente.

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Qual rotina das crianças que você quer saber?\nJoselito \nFilomena");
        string criancaEscolhida = Console.ReadLine();

        if (criancaEscolhida == "Joselito" )
        {
            Console.WriteLine("Rotina Do Joselito");
            Console.WriteLine("1- Escola das 07h as 12:30h");
            Console.WriteLine("2- Almoco das 13h as 14h");
            Console.WriteLine("3- Natacao das 14h as 16h");
            Console.WriteLine("4- Reforco escolar das 16h as 19h");

        }
        else if ( criancaEscolhida == "Filomena" )
        {
            Console.WriteLine("Rotina Da Filomena");
            Console.WriteLine("1- Escola das 07h as 12h");
            Console.WriteLine("2- Almoco das 12 as 13");
            Console.WriteLine("3- Futebol das 14h as 16h");
            Console.WriteLine("4- Dever de casa das 16h as 18h");
        }
    }    

}