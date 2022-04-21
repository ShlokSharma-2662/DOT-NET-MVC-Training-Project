using CarAPI.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.WebApp._3_BusisnessLogic.IBusisnessLogic
{
    public interface ICarBusisnessLogic
    {
        Task<List<Car>> SearchCarAsync(CarSearchParameters carSearchParameters);
        Task <bool> CarSaveAsync(Car car);
        Task<bool> DeleteCar(int id);
    }
}
