using Microsoft.AspNetCore.Mvc;
using techStoreMVC.Models;

namespace techStoreMVC.Controllers
{
    public class ProdutoController : Controller // o ":" significa herança
    // Herança = herdas as características de um Controller.
    // Conceito de PPO -> Programação Orientada a Objetos
    {
        // GET: ProdutoController

        // Passo 02 - Criar a ação 
        // Uma view depende de uma ação e vice-versa
        public ActionResult Index()
        {
            //Criar um objeto com vários produtos, por isso usamos um List
            List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Mouse Gamer", 129.90, 10),
                new Produto(1, "Teclado Mecânico", 249.90, 5),
                new Produto(1, "Monitor 24 polegadas", 899.90, 8),
                new Produto(1, "Headset Gamer", 179.90, 15)
            };
            return View(produtos);
        }

    }
}
