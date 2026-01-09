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
    public class AboutManager(IAboutDal _aboutDal) : IAboutService
    {
        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TInsert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TUpdate(About t)
        {
           _aboutDal.Update(t);
        }
    }
}
