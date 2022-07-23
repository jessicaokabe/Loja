using Loja.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<ProdutoViewModel>() { 
                new ProdutoViewModel { Id= 1, Nome = "Banana" }, 
                new ProdutoViewModel { Id= 2, Nome = "Maca" },
                new ProdutoViewModel { Id= 3, Nome = "kiwi" },
            };
            return View(model);
        }

        public IActionResult Save(int id)
        {
            var model = new ProdutoViewModel() { Id= 1, Nome = "Banana" };
            return View(model);
        }

        [HttpPost]
        public IActionResult Save(ProdutoViewModel model)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
