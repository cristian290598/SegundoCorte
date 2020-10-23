using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using deportes.domain;
using deportes.Infraestucture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace deportes.Controllers
{
    public class ProductoController : Controller
    {
        private DeportesDbContext _deportesDbContext;

        public ProductoController(DeportesDbContext deportesDbContext)
        {
            _deportesDbContext = deportesDbContext;  
        }
        public IActionResult Create()
        {
            Producto p = new Producto();
            
            return View(p);
        }

        [HttpPost]
        public IActionResult Create (Producto product)
        {
            _deportesDbContext.Productos.Add(product);
            int count=_deportesDbContext.SaveChanges();
            return View(product);
        }
        
        public IActionResult Create(Categoria category)
        {
            List<Categoria> categorias = null;
            categorias = _deportesDbContext.Categoria.ToList;
            List<SelectListItem> items = categorias.ConvertAll(c => {
                return new SelectListItem()
                {
                    Text = c.Nombre.ToString(),
                    Selected = false

                };
            });
            ViewBag.items = items;
            return View();
        }


    }
}
