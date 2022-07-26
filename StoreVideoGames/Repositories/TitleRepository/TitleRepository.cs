using EFDataAccess;
using EFDataAccess.Models;

namespace StoreVideoGames.Repositories.TitleRepository
{
    public class TitleRepository : Repository<Title>, ITitleRepository
    {
        public TitleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
