using System.Numerics;
using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crinado um Objeto
        // Chamando a minha classe "Produto"
        Produto produto = new Produto();

        produto.Nome = "Iphone 18 duo";
        produto.Preco = 20000;
        produto.Descricao = "O primeiro Iphone Dobrável";
        produto.Quantidade = 100;


        // Chamado a função que exibe as informações, mas com os dados que acabamos de atrelar a esse objeto(produto)
        produto.ExibirInformacoes();

        double total = produto.CalcularTotal();
        Console.WriteLine($"Total em Estoque: R${total:F2}");

        produto.ExibirMensagem("Caio");

        Personagem personagem = new Personagem();
        personagem.Nome = "Miranha";
        personagem.Energia = 40;

        personagem.RecuperarEnergia(20, "Descansou");
        Console.WriteLine($"Energia: {personagem.Energia}");

        personagem.RecuperarEnergia(30, "Alimento");
        Console.WriteLine($"Energia: {personagem.Energia}");

        // Método contrutor

        Pessoa pessoa1 = new Pessoa("Ana", 18);
        Pessoa pessoa2 = new Pessoa("Pedro", 20);

        pessoa1.Apresentar();
        pessoa2.Apresentar();   
    }
}