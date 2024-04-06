using System;
using System.ComponentModel;

class Program
{

    static bool EhPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        return false;
    }
    static void Main(string [] args)
    {
        int numero = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine(EhPar(numero));

    }
}