using System;

namespace Exercicio02Livros;

public class Ambiente
{
public string Nome = "";
public double Largura;
public double Comprimento;


public void ExibirMedidas()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Largura: {Largura:F1}");
        Console.WriteLine($"Comprimento: {Comprimento:F1}");
    }

public double CalcularArea()
    {
        return Largura * Comprimento;
    }

}

