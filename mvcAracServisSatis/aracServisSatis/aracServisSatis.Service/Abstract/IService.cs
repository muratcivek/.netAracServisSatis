using aracServisSatis.Data.Abstract;
using aracServisSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracServisSatis.Service.Abstract
{
    public interface IService<T> : IRepository<T> where T: IEntity, new()
    {
    }
}
