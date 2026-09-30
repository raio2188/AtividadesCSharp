using System.Numerics;
using Classes;

// Crinado um Objeto
// Chamando a minha classe "Produto"
Produto produto = new Produto();

produto.Nome = "Iphone 18 duo";
produto.Preco = 20000;
produto.Descricao= "O primeiro Iphone Dobrável";
produto.Quantidade = 100;


// Chamado a função que exibe as informações, mas com os dados que acabamos de atrelar a esse objeto(produto)
produto.ExibirInformacoes();

double total = produto.CalcularTotal();
Console.WriteLine($"Total em Estoque: R${total:F2}");
