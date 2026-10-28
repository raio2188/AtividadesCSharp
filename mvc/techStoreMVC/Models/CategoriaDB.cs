namespace techStoreMVC.Models;

public class CategoriaDB
{
    private static readonly List<Categoria> categorias = new()
        {
            new Categoria(1, "Informática", "Computadores e componentes", true),
            new Categoria(2, "Periféricos", "Mouse, teclado e acessórios", true),
            new Categoria(3, "Áudio", "Fones, caixas e microfones", true),
            new Categoria(4, "Monitores", "Telas e monitores", true),
            new Categoria(5, "Descontinuados", "Categorias fora de uso", false)
        };

        public List<Categoria> Listar()
    {
        return categorias;
    }

    public Categoria? buscarPorId(int id)
    {
        return categorias.FirstOrDefault(p => p.Id == id);
    }

    public void Adicionar(Categoria categoria)
    {
        categoria.Id = categorias.Count == 0
            ? 1
            : categorias.Max(p => p.Id) + 1;

        categorias.Add(categoria);
    }


    public bool Atualizar(Categoria categoriaAtualizada)
    {
        Categoria? categoriaExistente =
            buscarPorId(categoriaAtualizada.Id);

        if (categoriaExistente is null)
            return false;

        categoriaExistente.Nome = categoriaAtualizada.Nome;
        categoriaExistente.Descricao = categoriaAtualizada.Descricao;
        categoriaExistente.Ativa = categoriaAtualizada.Ativa;
        return true;
    }

    public bool Excluir(int id)
    {
        Categoria? categoria = buscarPorId(id);
        if (categoria is null)
            return false;
        categorias.Remove(categoria);

        return true;
    }
}