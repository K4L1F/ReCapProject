using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int Id);
        void Add(ICarDal car);
        void Update(ICarDal car);
        void Delete(ICarDal car);
    }
}
