using System;

class Program
{
    static void Main(string[] args)
    {
        const int ALTURA_MAXIMA_PERMITIDA = 9;
        const int ALTURA_MINIMA_PERMITIDA = 1;
        int alturaRecebida = 0;

        do
        {
            System.Console.WriteLine("Digite um tamanho de triangulo entre 1 e 9");
            alturaRecebida = int.Parse(Console.ReadLine());

            if (alturaRecebida > ALTURA_MAXIMA_PERMITIDA || alturaRecebida < ALTURA_MINIMA_PERMITIDA)
            {
                System.Console.WriteLine("Altura invalida, digite um numero entre 1 a 9!!!");
            }
            else
            {
                for (int linha = 1; linha <= alturaRecebida; linha++)
                {
                    for (int coluna = 1; coluna <= linha; coluna++)
                    {
                        Console.Write(coluna);
                    }
                    System.Console.WriteLine();
                }

            }
        }
        while (alturaRecebida > ALTURA_MAXIMA_PERMITIDA || alturaRecebida < ALTURA_MINIMA_PERMITIDA);
    }

}
