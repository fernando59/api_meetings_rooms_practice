using EFDataAccess;
using EFDataAccess.Models;

namespace StoreVideoGames.Repositories.EmployeeRepository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
