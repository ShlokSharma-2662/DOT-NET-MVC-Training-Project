using CarAPI.Common.Models;
using CarAPI.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.WebApp._2_Services.ICarServicesInterface
{
    public interface ICarServices
    {
        Task <List<Car>>CarSearchAsync(CarSearchParameters carSearchParameters);
        


        Task<bool> CarSaveAsync(Car car);
        Task<bool> DeleteCar(int id);
    }
}
