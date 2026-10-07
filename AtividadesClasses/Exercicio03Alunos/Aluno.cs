using System;

namespace Exercicio03Alunos;

public class Aluno
{
    public string Nome = "";
    public string Curso = "";
    public double nota1;
    public double nota2;

    public double CalcularMedia()
    {
        return (nota1 + nota2) / 2;
    }

    public void ExibirResultado()
    {
        Console.WriteLine($"Aluno: {Nome}");
        Console.WriteLine($"Curso: {Curso}");

        double media = CalcularMedia();
        Console.WriteLine($"Média: {media}");

        if (media >= 6){
            Console.WriteLine("Aprovado");
        }  
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
