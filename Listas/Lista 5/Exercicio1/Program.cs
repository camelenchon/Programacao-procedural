using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int regressivo = 200;
        
        for (int progressivo = 0; progressivo <= 100; progressivo++)
            if (progressivo % 2 == 0)
            {
                System.Console.WriteLine($"{progressivo} - {regressivo - (progressivo * 2)}");
            }
    }
}