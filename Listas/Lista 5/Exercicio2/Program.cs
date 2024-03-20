using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contadorTabuada = 10; contadorTabuada >= 1; contadorTabuada--)
        {
            for (int contador = 10; contador >= 1; contador--)
            {
                System.Console.WriteLine($"{contadorTabuada} X {contador} = {contadorTabuada * contador}");
            }
            System.Console.WriteLine();
        }
    }
}