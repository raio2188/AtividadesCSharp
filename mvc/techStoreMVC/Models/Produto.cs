namespace techStoreMVC.Models;

// Atributos
public class Produto
{
    public int Id {get; set;}
    public string Nome {get; set;}
    public double Preco {get; set;}
    public int Estoque {get; set;}

    // Método Construtor - Define valores iniciais desses atributos acima!!!!!!!!!!!

    public Produto(
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
