﻿using System;

class Program
{
    static void Main(string []args)
    {
        int somatorio = 0;
        
        do
        {
            int numeroRecebido = int.Parse(Console.ReadLine());
            if ( numeroRecebido < 0)
            {
                break;
            }
            if (numeroRecebido % 2 == 1)
            {
                somatorio = somatorio + numeroRecebido;
            }

        }while(true);
        
        Console.WriteLine("O somatorio de impares eh: " + somatorio);
    }
}