using System;
using System.Data;

class Program
{
    static void Main(string [] args)
    {
            
        Console.WriteLine("Digite seu usuario");
        string user = Console.ReadLine();

        Console.WriteLine("Digite a sua senha");
        string qualASuaSenha = Console.ReadLine();

    
        if ( user == "admin" && qualASuaSenha == "123senha" )
        {
            System.Console.WriteLine("Login realizado com sucesso");
        }
        else 
        {
            System.Console.WriteLine("Credenciais invalidas");
        }
    }
}