using CRUD_Repository_Ajax.Models;

namespace CRUD_Repository_Ajax.Repositories
{
   public class ProductRepository : IProductRepository
   {
      public DbInv _context;

      public ProductRepository(DbInv context)

      {
         this._context = context;
      }

      public IEnumerable<Product> GetAll()
      {
         return _context.Products.ToList();

      }

      public Product GetByID(int id)
      {
         return _context.Products.Find(id);
         
      }

      public int Save(Product entity)
      {
         _context.Products.Add(entity);
         var result = _context.SaveChanges();
         if (result > 0)
         {
            return 1;
         }
         else
         {
            return 0;
         }

      }

      public int Delete(int Id)
      {
         var s = _context.Products.Find(Id);
         _context.Products.Remove(s);
         _context.SaveChanges();
         return 1;
      }

      public int Update(Product entity)
      {
         // _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
         _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
         _context.SaveChanges();
         return 1;
      }
   }
}
