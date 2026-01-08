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
    public class StaffManager(IStaffDal _staffDal) : IStaffService
    {
        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff TGetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
