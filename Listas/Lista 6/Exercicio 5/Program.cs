using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int[] numeroArmazenados = new int[10];

        while (contador < 10)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
            {
                numeroArmazenados[contador] = numero;
                contador++;
            }
        }
        System.Console.WriteLine();
        for (contador = 0; contador < 10; contador++)
        {
            System.Console.WriteLine(numeroArmazenados[contador]);
        }
    }
}
