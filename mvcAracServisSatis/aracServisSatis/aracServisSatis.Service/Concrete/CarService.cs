using aracServisSatis.Data;
using aracServisSatis.Data.Concrete;
using aracServisSatis.Service.Abstract;

namespace aracServisSatis.Service.Concrete
{
    public class CarService : CarRepository, ICarService
    {
        public CarService(DatabaseContext context) : base(context)
        {
        }
    }
}
