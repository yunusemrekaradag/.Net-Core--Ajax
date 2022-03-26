using CoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreExample.Controllers
{
    public class ShopController : Controller
    {

        Context _context = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            var jsonCategory = JsonConvert.SerializeObject(_context.Categories);
            return Json(jsonCategory);  
        }
        public IActionResult ProductList()
        {
            var jsonProduct = JsonConvert.SerializeObject(_context.Products);
            return Json(jsonProduct);
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            _context.Categories.Add(c);
            _context.SaveChanges();
            var jsonCategory=JsonConvert.SerializeObject(c);
            return Json(jsonCategory);
        }
        [HttpPost]
        public IActionResult ProductAdd(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            var jsonProduct = JsonConvert.SerializeObject(p);
            return Json(jsonProduct);
        }

    }
}
