using System;

class Program
{

    static void Main(string[]args)
    {
        Console.WriteLine("Quantos centavos voce tem?");
        int cents = int.Parse(Console.ReadLine());

        int reais = cents / 100;
        int centavos = cents % 100;


        Console.WriteLine("O total em dinheiro eh: " + reais + " real(is) e " + centavos + " centavo(s).");
            }
}