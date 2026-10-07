using System;

namespace Exercicio01Livros;

public class Livro
{
public string Titulo = "";
public string Autor = "";
public int AnoPublicacao;


public void ExibirFicha()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano de publicação: {AnoPublicacao}");
    }

}

