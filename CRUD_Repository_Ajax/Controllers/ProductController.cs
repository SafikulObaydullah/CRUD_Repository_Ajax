using CRUD_Repository_Ajax.Models;
using CRUD_Repository_Ajax.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Repository_Ajax.Controllers
{
    public class ProductController : Controller
    {
        private DbInv _context;
      private IProductRepository _repository;
        public ProductController(DbInv context, IProductRepository repository)
        {
            _context = context;
           this._repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult getProducts()
        {
            List<Product> products = new List<Product>();
            
                products = _context.Products.OrderBy(p=>p.ProductName).ToList();

            //return Json(new  { Data = products }, new Newtonsoft.Json.JsonSerializerSettings());
            return Json(new { Data = products });
        }

      public IActionResult GetAll()
      {
         return Json(new { data = _repository.GetAll(), isSuccess = true });
      }
      public Product GetByID(int id)
      {
         return _repository.GetByID(id);
      }
      [HttpPost]
      public int Create(Product entity)
      {
         return _repository.Save(entity);
      }
      public int Delete(int id)
      {
         return _repository.Delete(id);
      }
      public int Edit(Product entity)
      {
         return _repository.Update(entity);
      }

   }
}
