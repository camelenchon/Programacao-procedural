using System;


class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }

        Console.WriteLine("Procura algum nome?");
        string nomeNovo = Console.ReadLine();

        string mensagem = "Não Achei";

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            if (nomeNovo == nomes[contador])
            {
                mensagem = "Achei";
            }
        }
        System.Console.WriteLine(mensagem);
    }
}