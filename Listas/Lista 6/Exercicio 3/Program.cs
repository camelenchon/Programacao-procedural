using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMEROS_INTEIROS = 3;
        int somatorio = 0;
        int[,] numeros = new int[NUMEROS_INTEIROS, NUMEROS_INTEIROS];


        for (int linha = 0; linha < NUMEROS_INTEIROS; linha++)
        {
            for (int coluna = 0; coluna < NUMEROS_INTEIROS; coluna++)
            {
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
                if (linha == coluna)
                {
                    somatorio += numeros[linha, coluna];
                }
            }
        }
        for (int linha = 0; linha < NUMEROS_INTEIROS; linha++)
        {
            for (int coluna = 0; coluna < NUMEROS_INTEIROS; coluna++)
            {
                Console.Write(numeros[linha, coluna] + " ");

            }
            Console.WriteLine();
        }

        System.Console.WriteLine($"{somatorio}");
    }
}
