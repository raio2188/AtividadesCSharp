using System;

namespace Classes;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, sou {Nome} e tenho {Idade} anos");
    }
}
