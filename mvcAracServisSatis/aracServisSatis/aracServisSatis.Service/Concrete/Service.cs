using aracServisSatis.Data;
using aracServisSatis.Data.Concrete;
using aracServisSatis.Entities;
using aracServisSatis.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracServisSatis.Service.Concrete
{
    public class Service<T> :Repository<T>,IService<T> where T :IEntity, new()
    {
        public Service(DatabaseContext context) : base(context)
        {

        }
    }
}
