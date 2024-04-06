using System;

class Program
{
    static void Main(string[] args)

    {
        System.Console.WriteLine("Preencha a matriz com numeros de 0 a 9");

        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(matriz);
        bool existeBalista = VerificarBalista(matriz);
        if (existeBalista)
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
    }

    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                matriz[i, c] = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
    static bool VerificarBalista(int[,] matriz)
    {

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {

                if (matriz[i, c] == 0)
                {
                    return true;
                }
            }

        }
        return false;
    }

}