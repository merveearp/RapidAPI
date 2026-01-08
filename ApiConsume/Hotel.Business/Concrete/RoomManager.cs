using Hotel.Business.Abstract;
using Hotel.DataAccess.Abstract;
using Hotel.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Business.Concrete
{
    public class RoomManager(IRoomDal _roomDal) : IRoomService
    {
        public void TDelete(Room t)
        {
             _roomDal.Delete(t);   
        }

        public Room TGetById(int id)
        {
           return _roomDal.GetById(id);
        }

        public List<Room> TGetList()
        {
           return _roomDal.GetList();
        }

        public void TInsert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void TUpdate(Room t)
        {
            _roomDal.Update(t);
        }
    }
}
