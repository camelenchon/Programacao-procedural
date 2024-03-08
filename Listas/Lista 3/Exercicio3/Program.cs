using System;

class Program
{
    static void Main(string [] args)
    {
        const string LOGIN_CORRETO = "admin";
        const string SENHA_CORRETA = "123admin";
        const int NUMERO_MAXIMO_TENTATIVAS = 3;
        string loginUsuario;
        string senhaUsuario; 

        int contadorTentativas = 1;

        do 
        {
            System.Console.WriteLine("Digite seu login:");
            loginUsuario = Console.ReadLine();
            System.Console.WriteLine("Digite sua senha:");
            senhaUsuario = Console.ReadLine();

            if (loginUsuario == LOGIN_CORRETO && senhaUsuario == SENHA_CORRETA)
            {
                System.Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            contadorTentativas++;
        }
        while (contadorTentativas <= NUMERO_MAXIMO_TENTATIVAS);

        if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
        {
            System.Console.WriteLine("Sua conta foi bloqueada!");
        }
    
    }
}