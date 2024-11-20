using aracServisSatis.Entities;
using System.Linq.Expressions;

namespace aracServisSatis.Data.Abstract
{
    public interface ICarRepository : IRepository<Arac>
    {
        Task<List<Arac>> GetCustomCarList();
        Task<List<Arac>> GetCustomCarList(Expression<Func<Arac, bool>> expressions);

        Task<Arac> GetCustomCar(int id);
    }
}
