using System;

class Program
{

    static void Main(string [] args)
    {
        const double FRETE_GRATIS = 150;
        double quantidadeDeCompras = 0;
        double valorDaCompra = 0;
        double somatorioCompras = 0;
        int contadorCompras = 1;

        System.Console.WriteLine("Quantos itens voce comprou?");
        double quantidadeCompras = double.Parse(Console.ReadLine());
        
        while (contadorCompras <= quantidadeCompras)
        {
            System.Console.WriteLine("Quanto voce pagou nesse item?");
            valorDaCompra = double.Parse(Console.ReadLine());
            somatorioCompras = somatorioCompras + valorDaCompra;
            contadorCompras++;         
        }

        if (somatorioCompras >= FRETE_GRATIS)
        {
            System.Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra de valor " + somatorioCompras);
        }
        else
        {
            System.Console.WriteLine("A compra não possui frete gratis");
        }
    }
}