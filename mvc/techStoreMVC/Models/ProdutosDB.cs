namespace techStoreMVC.Models;

public class ProdutosDB
{

    // Passo 01 - Criar / Trazer os dados de produtos do controller
    // Método que vai listar novos objetos de um produto
    // e armazená-los na variável produtos
    private static readonly List<Produto> produtos = new()
    {
        new Produto(1, "Mouse Gamer", 129.90, 10),
        new Produto(2, "Teclado Mecânico", 249.90, 5),
        new Produto(3, "Monitor 24 polegadas", 899.90, 8),
        new Produto(4, "Headset Gamer", 179.90, 15)
    };

    // Passo 02 - Criar os métodos do CRUD e remover toda regra de negócio do Controll
    // Responsabilidade do Listar: Devolve/Mostra todos os produtos. Igual ao Index
    // Controller 

    public List<Produto> Listar()
    {
        return produtos;
    }

    public Produto? buscarPorId(int id)
    {
        return produtos.FirstOrDefault(p => p.Id == id);
    }

    public void Adicionar(Produto produto)
    {
        produto.Id = produtos.Count == 0
            ? 1
            : produtos.Max(p => p.Id) + 1;

        produtos.Add(produto);
    }


    public bool Atualizar(Produto produtoAtualizado)
    {
        Produto? produtoExistente =
            buscarPorId(produtoAtualizado.Id);

        if (produtoExistente is null)
            return false;

        produtoExistente.Nome = produtoAtualizado.Nome;
        produtoExistente.Preco = produtoAtualizado.Preco;
        produtoExistente.Estoque = produtoAtualizado.Estoque;
        return true;
    }

    public bool Excluir(int id)
    {
        Produto? produto = buscarPorId(id);
        if (produto is null)
            return false;
        produtos.Remove(produto);

        return true;
    }
}

