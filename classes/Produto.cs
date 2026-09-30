using System;

namespace Classes; 

public class Produto // Classe -> representa algo da vida real
{
    // Atributos desse item
    public string Nome = "";
    public double Preco;
    public int Quantidade;
    public string Descricao = "";

    //Método / Função. Executa uma ação
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: {Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Descrição: {Descricao}");
    }

    public double CalcularTotal()
    {
        return Preco * Quantidade;
    }
    // Função com parâmetro, espera receber o nome do usuário

    public void ExibirMensagem(string nome)
    {
        Console.WriteLine($"Olá, {nome}");
    }
}
