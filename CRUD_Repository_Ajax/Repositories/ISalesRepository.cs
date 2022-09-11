using CRUD_Repository_Ajax.Models;

namespace CRUD_Repository_Ajax.Repositories
{
    public interface ISalesRepository
    {
        int Save(SalesMaster salesMaster);
        int Update(SalesMaster salesMaster);
        int Delete(int Id);
        IEnumerable<SalesMaster> GetAll();
        SalesMaster GetByID(int id);

    }
}
