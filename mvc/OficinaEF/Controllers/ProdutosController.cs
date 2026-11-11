using Microsoft.AspNetCore.Mvc;

namespace OficinaEF.Controllers; //Onde está o arquivo


public class ProdutosController : Controller
{
    //Agora temos as ações, como iremos acessar uma página
    public IActionResult Index()
    {
        return Content("Catálogo de Produtos");
    }
}