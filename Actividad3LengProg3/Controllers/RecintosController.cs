using Microsoft.AspNetCore.Mvc;
using Actividad4LengProg3.Models;

namespace Actividad4LengProg3.Controllers
{
    public class RecintosController : Controller
    {
        private static List<RecintoViewModel> listaRecintos = new();

        public IActionResult Index()
        {
            return View(listaRecintos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RecintoViewModel recinto)
        {
            if (ModelState.IsValid)
            {
                listaRecintos.Add(recinto);
                return RedirectToAction("Index");
            }
            return View(recinto);
        }

        public IActionResult Delete(int codigo)
        {
            var r = listaRecintos.FirstOrDefault(x => x.Codigo == codigo);
            if (r != null) listaRecintos.Remove(r);
            return RedirectToAction("Index");
        }
    }
}
