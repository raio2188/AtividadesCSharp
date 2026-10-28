namespace techStoreMVC.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }
    public int Estoque { get; set; }

    // O MVC usa este construtor para receber o formulário.
    // Tivemos de alterar o construtor para que tratassemos o erro ao editar
    public Produto()
    {
    }

    public Produto(int id, string nome, double preco, int estoque)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}