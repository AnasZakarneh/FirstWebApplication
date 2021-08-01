using DB.Models;

namespace DB.Repositories
{
    public interface IShiftRepository : IRepository<Shift, int>
    {
        Shift RetrieveShiftDetails(int id);
    }
}
