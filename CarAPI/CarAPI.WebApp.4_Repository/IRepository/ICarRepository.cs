using CarAPI.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.WebApp._4_Repository.IRepository
{
    public interface ICarRepository
    {
        Task<List<Car>> SearchCarAsync(CarSearchParameters carSearchingParameters);
        Task<bool> CarSaveAsync(Car car);
        Task<bool> DeleteCar(int id);
    }
}
