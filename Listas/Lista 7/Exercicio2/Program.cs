using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(String[] args)
    {
        int[] vetor = { 7, 12, 47 };

        int oMaiorNumero = MaiorNumero(vetor);

        System.Console.WriteLine(oMaiorNumero);
    }


    static int MaiorNumero(int[] numero)
    {
        int oMaiorNumero = int.MinValue;

        for (int i = 0; i < numero.Length; i++)
        {
            if (numero[i] > oMaiorNumero)
            {
                oMaiorNumero = numero[i];
            }

        }
        return oMaiorNumero;

    }
}
