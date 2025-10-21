using Actividad4LengProg3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;

namespace Actividad4LengProg3.Controllers
{

    public class EstudiantesController : Controller
    {
        private static List<EstudianteViewModel> _estudiantes = new();

        
        private static readonly List<SelectListItem> OpcionesCarrera = new()
        {
            new("Ing. Software","Ing. Software"),
            new("Redes","Redes"),
            new("Contabilidad","Contabilidad"),
            new("Administración","Administración")
        };

        private static readonly List<SelectListItem> OpcionesRecinto = new()
        {
            new("Santo Domingo","Santo Domingo"),
            new("San Pedro de Macorís","San Pedro de Macorís"),
            new("La Romana","La Romana")
        };

        private static readonly List<SelectListItem> OpcionesGenero = new()
        {
            new("Masculino","Masculino"),
            new("Femenino","Femenino"),
            new("Otro","Otro")
        };

        private static readonly List<SelectListItem> OpcionesTurno = new()
        {
            new("Mañana","Mañana"),
            new("Tarde","Tarde"),
            new("Noche","Noche")
        };

        public IActionResult Index()
        {
            ViewBag.Carreras = OpcionesCarrera;
            ViewBag.Recintos = OpcionesRecinto;
            ViewBag.Generos = OpcionesGenero;
            ViewBag.Turnos = OpcionesTurno;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar(EstudianteViewModel model)
        {
            if (ModelState.IsValid)
            {
                _estudiantes.Add(model);
                return RedirectToAction(nameof(Lista));
            }

            
            ViewBag.Carreras = OpcionesCarrera;
            ViewBag.Recintos = OpcionesRecinto;
            ViewBag.Generos = OpcionesGenero;
            ViewBag.Turnos = OpcionesTurno;
            return View("Index", model);
        }

        public IActionResult Lista()
        {
            return View(_estudiantes);
        }

    }

}
