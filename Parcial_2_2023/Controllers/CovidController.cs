using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020ZA601_2020AA603_2020SC603.Models;
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
            var listadodepartamentos=(from m in _covidDbContext.departamentos
                                      select m).ToList();
            ViewData["listadodepartamentos"] = new SelectList(listadodepartamentos, "id_departamento", "nombre_departamento");

            var listadogenero = (from m in _covidDbContext.generos
                                 select m).ToList();
            ViewData["listadogenero"] = new SelectList(listadogenero, "id_genero", "genero");

            var listadocovids = (from c in _covidDbContext.casos_reportados
                                 join d in _covidDbContext.departamentos on c.id_departamento equals d.id_departamento
                                 join g in _covidDbContext.generos on c.id_genero equals g.id_genero
                                 select new
                                 {
                                     departamentos = d.nombre_departamento,
                                     genero = g.genero,
                                     confirmados = c.confirmados,
                                     recuperados = c.recuperados,
                                     fallecidos = c.fallecidos,

                                 }).ToList();
            ViewData["listadocovid"] = listadocovids;

            return View();
            
            
        }
        public IActionResult CrearDatos(casos_reportados nuevoDato)
        {
            _covidDbContext.Add(nuevoDato);
            _covidDbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
