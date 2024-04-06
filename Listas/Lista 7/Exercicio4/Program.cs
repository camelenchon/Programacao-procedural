using System;

class Program
{
    static void PreencherVagao(int[] pesosDosVagoes)
    {

        for (int i = 0; i < 12; i++)
        {
            pesosDosVagoes[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void PesarVagao(int[] pesosDosVagoes)
    {
        for (int i = 0; i < pesosDosVagoes.Length; i++)
        {
            if (pesosDosVagoes[i] > 50)
            {
                System.Console.WriteLine($"{i + 1}" + "° vagao esta ultrapassou o limite de peso");
            }
        }
    }
    static void Main(string[] args)
    {
        const int TAMANHO_do_VAGAO = 12;
        int[] tamanhoVagao = new int[TAMANHO_do_VAGAO];

        PreencherVagao(tamanhoVagao);
        PesarVagao(tamanhoVagao);
    }
}
