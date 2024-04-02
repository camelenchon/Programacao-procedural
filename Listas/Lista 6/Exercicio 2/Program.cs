using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_PESSOAS = 10;
        string[] nomes = new string[NUMERO_PESSOAS];

        for (int contador = 0; contador < NUMERO_PESSOAS; contador++)
        {
            nomes[contador] = Console.ReadLine();

        }
        for (int contador = 9; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.WriteLine(nomes[contador]);
            }
        }
        System.Console.WriteLine();
    }
}