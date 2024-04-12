using System;
struct Produto
{
    public int id;
    public string nome;
    public double valor;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        Produto[] produto = new Produto[4];

        for (int i = 0; i < produto.Length; i++)
        {
            produto[i].id = Convert.ToInt32(Console.ReadLine());
            produto[i].nome = Console.ReadLine();
            produto[i].valor = Convert.ToDouble(Console.ReadLine());
            produto[i].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for (int i = 0; i < produto.Length; i++)
        {
            if (produto[i].disponivelEmEstoque == true)
            {
                System.Console.WriteLine(produto[i].nome);
                System.Console.WriteLine(Math.Round(produto[i].valor, 2));
            }
        }
    }

}