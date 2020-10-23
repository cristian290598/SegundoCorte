using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using deportes.domain;
using deportes.Infraestucture;
using Microsoft.AspNetCore.Mvc;

namespace deportes.Controllers
{
    public class CategoriaController : Controller
    {

        private DeportesDbContext _deportesDbContext;

        public CategoriaController(DeportesDbContext deportesDbContext)
        {
            _deportesDbContext = deportesDbContext;
        }
        public IActionResult Create()
        {
            Categoria c = new Categoria();

            return View(c);
        }


        [HttpPost]
        public IActionResult Create(Categoria category)
        {
            _deportesDbContext.Categorias.Add(category);
            int count = _deportesDbContext.SaveChanges();
            return View(category);
        }
    }
}
