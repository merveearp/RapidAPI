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
    public class TestimonialManager(ITestimonialDal _testimonialDal) : ITestimonialService
    {
        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
