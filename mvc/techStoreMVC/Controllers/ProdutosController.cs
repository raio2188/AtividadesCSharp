using Microsoft.AspNetCore.Mvc;
using techStoreMVC.Models;

namespace techStoreMVC.Controllers
{
    public class ProdutosController : Controller // o ":" significa herança
    // Herança = herda as caracteristicas de um Controller. :)
    // Conceito de POO -> Programação Orientada a Objetos
    {
        private readonly ProdutosDB _produtoDB;
        public ProdutosController()
        {
            _produtoDB = new ProdutosDB();
        }
        // Passo 02 - Criar a ação
        // Uma view Depende de uma ação e vice-versa
        [HttpGet] // Verbo Http -> para ter os produtos
        public ActionResult Index()
        {
            List<Produto> produtos = _produtoDB.Listar();
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Produto? produto = _produtoDB.buscarPorId(id);
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
        public IActionResult Create(Produto produto)
        {
            if(!ModelState.IsValid)
                return View(produto);

            _produtoDB.Adicionar(produto);
            TempData["Sucesso"] = 
                "Produto cadastrado com sucesso!";

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Produto? produto = _produtoDB.buscarPorId(id);
             if (produto is null)
                return NotFound();
            return View(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Produto produto, int id)
        {
            if (id != produto.Id)
                return BadRequest();

            if(!ModelState.IsValid)
                return View(produto);

            bool atualizou = _produtoDB.Atualizar(produto);    
            if(!atualizou)
                return NotFound();
                    
            TempData["Sucesso"] = 
                "Produto atualizado com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Produto? produto = _produtoDB.buscarPorId(id);
             if (produto is null)
                return NotFound();
            return View(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed( int id)
        {
            bool excluiu = _produtoDB.Excluir(id);    
            if(!excluiu)
                return NotFound();
                    
            TempData["Sucesso"] = 
                "Produto excluído com sucesso!";

            return RedirectToAction(nameof(Index));
        }
    }
}
