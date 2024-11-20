using aracServisSatis.Data.Abstract;
using aracServisSatis.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace aracServisSatis.Data.Concrete
{
    public class CarRepository : Repository<Arac>, ICarRepository
    {
        public CarRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<Arac> GetCustomCar(int id)
        {
            return await _dbSet.AsNoTracking().Include(x => x.marka).FirstOrDefaultAsync(c=>c.Id == id);
        }

        public async Task<List<Arac>> GetCustomCarList()
        {
            return await _dbSet.AsNoTracking().Include(x=>x.marka).ToListAsync();
        }

        public async Task<List<Arac>> GetCustomCarList(Expression<Func<Arac, bool>> expressions)
        {
            return await _dbSet.Where(expressions).AsNoTracking().Include(x => x.marka).ToListAsync();
        }
    }
}
