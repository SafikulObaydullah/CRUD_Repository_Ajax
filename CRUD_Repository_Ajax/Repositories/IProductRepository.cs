using CRUD_Repository_Ajax.Models;

namespace CRUD_Repository_Ajax.Repositories
{
   public interface IProductRepository
   {
      int Save(Product product);
      int Update(Product product);
      int Delete(int Id);
      IEnumerable<Product> GetAll();
      Product GetByID(int id);
   }
}
