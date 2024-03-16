using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contadorTabuada = 1; contadorTabuada <= 10; contadorTabuada++)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                System.Console.WriteLine($"{contadorTabuada} X {contador} = {contadorTabuada * contador}");
            }
            System.Console.WriteLine();
        }

    }
}