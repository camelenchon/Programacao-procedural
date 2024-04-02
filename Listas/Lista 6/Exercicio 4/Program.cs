using System;

class Program
{
    static void Main(string[] args)
    {

        const int NUMEROS_INTEIROS = 3;
        int[,] numeros = new int[NUMEROS_INTEIROS, NUMEROS_INTEIROS];


        for (int linha = 0; linha < NUMEROS_INTEIROS; linha++)
        {
            for (int coluna = 0; coluna < NUMEROS_INTEIROS; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());

                if (coluna + linha == NUMEROS_INTEIROS - 1)
                {
                    numeros[linha, coluna] *= 2;
                }
            }
        }
        for (int linha = 0; linha < NUMEROS_INTEIROS; linha++)
        {
            for (int coluna = 0; coluna < NUMEROS_INTEIROS; coluna++)
            {
                Console.Write(numeros[linha, coluna] + " | ");

            }
            Console.WriteLine();
        }
    }
}