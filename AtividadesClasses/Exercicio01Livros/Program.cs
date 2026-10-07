using System.Numerics;
using Exercicio01Livros;

internal class Program
{
    private static void Main(string[] args)
    {
        Livro domCasmurro = new Livro();
        
        domCasmurro.Titulo = "Dom Casmurro — edição comentada";
        domCasmurro.Autor = "Machado de Assís";
        domCasmurro.AnoPublicacao = 1899;

        Livro PequenoPrincipe = new Livro();
        
        PequenoPrincipe.Titulo = "PequenoPrincipe";
        PequenoPrincipe.Autor = "Antoine de Saint-Exupéry";
        PequenoPrincipe.AnoPublicacao = 1943;

        domCasmurro.ExibirFicha();
        Console.WriteLine(); // pular linha
        PequenoPrincipe.ExibirFicha();
    }
}