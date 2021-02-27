using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
            new Car { carId = 1, brandId = 1, colorId = 1, DailyPrice = 650, Description = "Tesla E ,Elektrikli ,Otomatik+Maunel", ModelYear = 2017 },
            new Car { carId = 2, brandId = 1, colorId = 1, DailyPrice = 550, Description = "Tesla X ,Elektrikli ,Otomatik+Manuel", ModelYear = 2020 },
            new Car { carId = 3, brandId = 1, colorId = 2, DailyPrice = 450, Description = "Tesla S ,Elektrikli ,Otomatik+Manuel", ModelYear = 2019 },
            new Car { carId = 4, brandId = 2, colorId = 1, DailyPrice = 350, Description = "Audi a6 Sedan,Dizel ,Yarı Otomatik", ModelYear = 2011 },
            new Car { carId = 5, brandId = 2, colorId = 2, DailyPrice = 250, Description = "Audi a6 Avanta,Dizel ,Yarı Otomatik", ModelYear = 2015 }
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.carId == car.carId);
            _car.Remove(carToDelete);
        }
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public List<Car> GetAll()
        {
            return _car;
        }
        public List<Car> GetAllByCategory(int CarId)
        {
            return _car.Where(c => c.carId == CarId).ToList();
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.carId == car.carId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.colorId = car.colorId;
            carToUpdate.brandId = car.brandId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}