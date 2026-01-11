using Hotel.Business.Abstract;
using Hotel.DataAccess.Abstract;
using Hotel.Entity.Concrete;
namespace Hotel.Business.Concrete
{
    public class SubscribeManager(ISubscribeDal _subscribeDal) : ISubscribeService
    {
       
        public void TDelete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe TGetById(int id)
        {
           return _subscribeDal.GetById(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
