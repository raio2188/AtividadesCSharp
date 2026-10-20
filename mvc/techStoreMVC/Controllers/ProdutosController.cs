using Microsoft.AspNetCore.Mvc;
using techStoreMVC.Models;

namespace techStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa herança
    // Herança = herdas as características de um Controller.
    // Conceito de PPO -> Programação Orientada a Objetos
    {
        // GET: ProdutoController

        // Passo 02 - Criar a ação 
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            //Criar um objeto com vários produtos, por isso usamos um List
            List<Produtos> produtos = new List<Produtos>
            {
                new Produtos(1, "Mouse Gamer", 129.90, 10),
                new Produtos(2, "Teclado Mecânico", 249.90, 5),
                new Produtos(3, "Monitor 24 polegadas", 899.90, 8),
                new Produtos(4, "Headset Gamer", 179.90, 15)
            };
            return View(produtos);
        }

    }
}
