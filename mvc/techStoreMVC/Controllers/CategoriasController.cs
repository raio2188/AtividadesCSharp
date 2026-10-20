
using Microsoft.AspNetCore.Mvc;
using techStoreMVC.Models;

namespace techStoreMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private static readonly List<Categorias> categorias = new()
        {
            new Categorias(1, "Informática", "Computadores e componentes", true),
            new Categorias(2, "Periféricos", "Mouse, teclado e acessórios", true),
            new Categorias(3, "Áudio", "Fones, caixas e microfones", true),
            new Categorias(4, "Monitores", "Telas e monitores", true),
            new Categorias(5, "Descontinuados", "Categorias fora de uso", false)
        };

        public IActionResult Index()
        {
            return View(categorias);
        }

        public IActionResult ativas()
        {
            var categoriasAtivas = categorias
                .Where(categoria => categoria.Ativa)
                .ToList();

            return View(categoriasAtivas);
        }
    }   
}
