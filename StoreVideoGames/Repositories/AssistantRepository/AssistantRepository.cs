using EFDataAccess;
using EFDataAccess.Models;

namespace StoreVideoGames.Repositories.AssistantRepository
{
    public class AssistantRepository : Repository<Assistant>, IAssistantRepository
    {
        public AssistantRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
