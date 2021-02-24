using Microsoft.AspNetCore.Mvc;
using POST2.Models;
using POST2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POST2.Controllers
{
    public class LlegadasController : Controller
    {

        IRepositoryLlegadas repo;

        public LlegadasController(IRepositoryLlegadas repo) { 
            this.repo = repo; 
        }

        public IActionResult Index()
        {
            List<Llegada> Llegadas = this.repo.GetLlegadas();
            return View(Llegadas);
        }

        public IActionResult Details(int id)
        {
            Llegada Llegada = this.repo.BuscarLlegada(id);
            return View(Llegada);
        }
        
        public IActionResult Delete(int id)
        {
            this.repo.EliminarLlegada(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int Id, string Fly, string Airlane, string From, string To, int Gate, string Hour)
        {
            this.repo.InsertarLlegada(Id, Fly, Airlane, From, To, Gate, Hour);
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            Llegada Llegada = this.repo.BuscarLlegada(id);
            return View(Llegada);
        }
        [HttpPost]
        public IActionResult Edit(int Id, string Fly, string Airlane, string From, string To, int Gate, string Hour)
        {
            this.repo.ModificarLlegada(Id, Fly, Airlane, From, To, Gate, Hour);
            return RedirectToAction("Index");
        }


    }
}
