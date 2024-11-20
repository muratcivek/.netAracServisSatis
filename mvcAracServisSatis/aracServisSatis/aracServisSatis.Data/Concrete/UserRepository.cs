using aracServisSatis.Data.Abstract;
using aracServisSatis.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace aracServisSatis.Data.Concrete
{
    public class UserRepository : Repository<Kullanici>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<List<Kullanici>> GetCustomList()
        {
            return await _dbSet.AsNoTracking().Include(x => x.Rol).ToListAsync();
        }

        public async Task<List<Kullanici>> GetCustomList(Expression<Func<Kullanici, bool>> expressions)
        {
            return await _dbSet.Where(expressions).AsNoTracking().Include(x => x.Rol).ToListAsync();
        }
    }
}
