using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.brandId == Id);
        }
        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.colorId == Id);
        }
        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice <= max && c.DailyPrice >= min);
        }
    }
}
