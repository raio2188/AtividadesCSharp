namespace techStoreMVC.Models;

// Atributos
public class Produtos
{
    public int Id {get; set;}
    public string Nome {get; set;}
    public double Preco {get; set;}
    public int Estoque {get; set;}

    // Método Construtor - Define valores iniciais desses atributos acima!!!!!!!!!!!

    public Produtos(
        int id,
        string nome,
        double preco,
        int estoque
    )
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}
