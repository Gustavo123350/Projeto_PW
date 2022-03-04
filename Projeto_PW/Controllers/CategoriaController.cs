using Microsoft.AspNetCore.Mvc;
using Projeto_PW.Models;
using System.Collections.Generic;

namespace Projeto_PW.Controllers
{
    public class CategoriaController : Controller
    {
        public static List<CategoriaModel> lsCategoria = new List<CategoriaModel>();
        public IActionResult Index()
        {
            return View(lsCategoria);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoriaModel categoria)
        {
            lsCategoria.Add(categoria);
            return RedirectToAction("Index");
        }
    }
}
