using System;
using System.Diagnostics;

class Program
{
    //“Eu preciso de um programa que receba as 4 notas de um aluno. O programa deve calcular a média aritmética das notas desse aluno. Após calculada a média o programa deve verificar se o
    // aluno foi aprovado, reprovado ou se está em recuperação”. 
    //Os critérios são:
    static void Main(string [] args)
    {
           
        System.Console.WriteLine("Digite a nota do primeiro bimestre");
        double notaPrimeiro = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a nota do segundo bimetre"); 
        double notaSegundo = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a nota do terceiro bimestre");
        double notaTerceiro = double.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Digite a nota do quarto bimestre");
        double notaQuarto = double.Parse(Console.ReadLine());

        double mediaDoAluno = (notaPrimeiro + notaSegundo + notaTerceiro + notaQuarto) / 4;
         
        if (mediaDoAluno >= 5.0)
        {
            System.Console.WriteLine("Aluno aprovado");
        }
        else if (mediaDoAluno < 5.0 && mediaDoAluno >= 3.0 )
        {
            System.Console.WriteLine("Aluno em recuperacao");
        }
        else if (mediaDoAluno < 3.0)
        {
            System.Console.WriteLine("Aluno reprovado");
        }
       
    }
}