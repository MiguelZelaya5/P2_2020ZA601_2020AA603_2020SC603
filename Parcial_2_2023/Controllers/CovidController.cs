using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Parcial_2_2023.Models;

namespace Parcial_2_2023.Controllers
{
    public class CovidController : Controller
    {
        private readonly covidDbContext _covidDbContext;
        public CovidController(covidDbContext covidDbContext) 
        {
            _covidDbContext = covidDbContext;
        }
        public IActionResult Index()
        {
            var listadodepartamentos=(from m in _covidDbContext.casos_reportados join n in _covidDbContext.departamentos
                                      on m.id_departamento equals n.id_departamento
                                      select m).ToList();
            ViewData["listadodepartamentos"] = new SelectList(listadodepartamentos, "id_departamento", "nombre_departamento");
            return View();
        }

    }
}
