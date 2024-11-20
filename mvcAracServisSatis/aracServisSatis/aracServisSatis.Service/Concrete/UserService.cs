using aracServisSatis.Data;
using aracServisSatis.Data.Concrete;
using aracServisSatis.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aracServisSatis.Service.Concrete
{
    public class UserService : UserRepository,IUserService
    {
        public UserService(DatabaseContext context) : base(context)
        {
        }
    }
}
