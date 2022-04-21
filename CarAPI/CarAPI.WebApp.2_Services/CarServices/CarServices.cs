using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAPI.Common.Models;
using CarAPI.WebApp._2_Services.ICarServicesInterface;
using CarAPI.WebApp._2_Services.CarServices;
using CarAPI.WebApp._3_BusisnessLogic.IBusisnessLogic;

namespace CarAPI.WebApp._2_Services.CarServices
{
    public class CarServices : ICarServices
    {
        private ICarBusisnessLogic _icarBusisnessLogic;

        public CarServices(ICarBusisnessLogic _icarBusisnessLogic)
        {
            this._icarBusisnessLogic = _icarBusisnessLogic;
        }


        public async Task<List<Car>> CarSearchAsync(CarSearchParameters carSearchParameters)
        {
            return await this._icarBusisnessLogic.SearchCarAsync(carSearchParameters);
        }

        public async Task<bool> CarSaveAsync(Car car)
        {
            return await this._icarBusisnessLogic.CarSaveAsync(car);
        }

      

        public async Task<bool> DeleteCar(int id)
        {
            return await this._icarBusisnessLogic.DeleteCar(id);
        }
    }
}
