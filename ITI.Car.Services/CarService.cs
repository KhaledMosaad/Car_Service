using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Car.Services
{
    public class CarService : ICarService
    {
        private static readonly List<Car> Cars = new List<Car>
        {
            new Car{Id=1,Model="Fiat",Price=8000},
            new Car{Id=2,Model="BMW",Price=50000}
        };
        public Car Add(Car car)
        {
            Cars.Add(car);
            return car;
        }

        public List<Car> GetAll()
        {
            return Cars;
        }

        public Car GetbyId(string id)
        {
            return Cars.FirstOrDefault(c => c.Id == int.Parse(id));
        }

        public List<Car> GetbyModel(string model)
        {
            return Cars.Where(c => c.Model == model).ToList();
        }

        public Car Modify(Car car)
        {
            Cars.RemoveAll(c => c.Id == car.Id);
            Cars.Add(car);
            return car;
        }

        public void Remove(string id)
        {
            Cars.RemoveAll(c => c.Id == int.Parse(id));
        }
    }
}
