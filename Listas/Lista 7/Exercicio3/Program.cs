using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

class Program
{
    static String ClassificarNadador(int idadeJogador)
    {
        if (idadeJogador < 12)
        {
            return "Infantil";
        }
        else if (idadeJogador > 12 && idadeJogador < 14)
        {
            return "Juvenil A";
        }
        else if (idadeJogador > 14 && idadeJogador < 17)
        {
            return "Juvenil B";
        }
        else if (idadeJogador >= 18)
        {
            return "Adulto";
        }
        return "";
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Qual a idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        String resultado = ClassificarNadador(idade);

        System.Console.WriteLine(resultado);
    }
}