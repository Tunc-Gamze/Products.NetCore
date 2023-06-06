using Microsoft.AspNetCore.Mvc;
using Products.NetCore.Models;


namespace Products.NetCore.Controllers
{
  
    
        public class ProductsController : Controller
        {
            private AppDbContext _context;

            private readonly ProductRepository _productRepository;

            public ProductsController(AppDbContext context)
            {
                _productRepository = new ProductRepository();

                _context = context;

            }

            public IActionResult Index()
            {
                List<Product> products = _context.Products.ToList();


                return View(products);
            }

            public IActionResult Urunler()
            {



               List<Product> products = _context.Products.ToList();


                return View(products);
            }
        

            public IActionResult Remove(int id)
            {
                var product = _context.Products.Find(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
                TempData["status"] = "Ürün başarıyla Silindi.";
                return RedirectToAction("Index");
            }

            [HttpGet]

            public IActionResult Add()
            {
                return View();
            }

            [HttpPost]

            public IActionResult Add(Product newProduct)
            {

                _context.Products.Add(newProduct);
                _context.SaveChanges();
                TempData["status"] = "Ürün başarıyla Eklendi.";
                return RedirectToAction("Index");
            }



            [HttpGet]
            public IActionResult Update(int id)
            {
                var product = _context.Products.Find(id);

                return View(product);
            }

            [HttpPost]
            public IActionResult Update(Product updateProduct)
            {
                _context.Products.Update(updateProduct);
                _context.SaveChanges();
                TempData["status"] = "Ürün başarıyla güncellendi.";
                return RedirectToAction("Index");
            }

        }
    

}

