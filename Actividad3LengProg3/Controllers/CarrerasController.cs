using Microsoft.AspNetCore.Mvc;
using Actividad4LengProg3.Models;

namespace Actividad4LengProg3.Controllers
{
    public class CarrerasController : Controller
    {
        private static List<CarreraViewModel> listaCarreras = new();

        public IActionResult Index()
        {
            return View(listaCarreras);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarreraViewModel carrera)
        {
            if (ModelState.IsValid)
            {
                listaCarreras.Add(carrera);
                return RedirectToAction("Index");
            }
            return View(carrera);
        }

        public IActionResult Delete(int codigo)
        {
            var c = listaCarreras.FirstOrDefault(x => x.Codigo == codigo);
            if (c != null) listaCarreras.Remove(c);
            return RedirectToAction("Index");
        }
    }
}
