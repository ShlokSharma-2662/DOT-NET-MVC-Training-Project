using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAPI.Common.Models;
using CarAPI.WebApp._3_BusisnessLogic.IBusisnessLogic;
using CarAPI.WebApp._4_Repository.IRepository;

namespace CarAPI.WebApp._3_BusisnessLogic.BusinessLogic
{
    public class CarBusisnessLogic : ICarBusisnessLogic
    {
        private ICarRepository _icarRepository;
        public CarBusisnessLogic(ICarRepository _icarRepository)
        {
            this._icarRepository = _icarRepository;
        }

        public async Task<bool> CarSaveAsync(Car car)
        {
            return await this._icarRepository.CarSaveAsync(car);
        }

        public async Task<bool> DeleteCar(int id)
        {
            return await this._icarRepository.DeleteCar(id);
        }

        public async Task<List<Car>> SearchCarAsync(CarSearchParameters carSearchParameters)
        {
            return await this._icarRepository.SearchCarAsync(carSearchParameters);
        }
    }
}
