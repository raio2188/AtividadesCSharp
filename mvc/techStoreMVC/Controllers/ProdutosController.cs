using Microsoft.AspNetCore.Mvc;
using techStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa herança
    // Herança = herda as caracteristicas de um Controller. :)
    // Conceito de POO -> Programação Orientada a Objetos
    {
        private readonly ProdutosDB _produtosDB;
        public ProdutosController()
        {
            _produtosDB = new ProdutosDB();
        }
        // Passo 02 - Criar a ação
        // Uma view Depende de uma ação e vice-versa
        [HttpGet] // Verbo Http -> para ter os produtos
        public ActionResult Index()
        {
            List<Produtos> produtos = _produtosDB.Listar();
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Produtos? produto = _produtosDB.buscarPorId(id);
            if (produto is null)
                return NotFound();

                return View(produto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produtos produto)
        {
            if(!ModelState.IsValid)
                return View(produto);

            _produtosDB.Adicionar(produto);
            TempData["Sucesso"] = 
                "Produto cadastrado com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produtos? produto = _produtosDB.buscarPorId(id);
             if (produto is null)
                return NotFound();
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Produtos produto, int id)
        {
            if (id != produto.Id)
                return BadRequest();

            if(!ModelState.IsValid)
                return View(produto);

            bool atualizou = _produtosDB.Atualizar(produto);    
            if(!atualizou)
                return NotFound();
                    
            TempData["Sucesso"] = 
                "Produto atualizado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Produtos? produto = _produtosDB.buscarPorId(id);
             if (produto is null)
                return NotFound();
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed( int id)
        {
            bool excluiu = _produtosDB.Excluir(id);    
            if(!excluiu)
                return NotFound();
                    
            TempData["Sucesso"] = 
                "Produto excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}
