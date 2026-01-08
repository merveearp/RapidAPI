using Hotel.DataAccess.Abstract;
using Hotel.DataAccess.Concrete;
using Hotel.DataAccess.Repositories;
using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DataAccess.Entity_Framework
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
        }
    }
}
