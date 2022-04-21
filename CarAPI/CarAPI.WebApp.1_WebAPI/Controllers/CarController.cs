using CarAPI.Common.Models;
using CarAPI.WebApp._2_Services.ICarServicesInterface;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.WebApp._1_WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SearchCar")]
    public class CarController : Controller
    {
        private ICarServices _icarservices;
        public CarController(ICarServices _icarservices)
        {
            this._icarservices = _icarservices;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Car>))]
        [Route("api/SearchCar")]
        public async Task<IActionResult> Get(CarSearchParameters carSearchParameters)
        {
            var car = await this._icarservices.CarSearchAsync(carSearchParameters);
            if (car == null || !car.Any())
            {
                return NotFound();
            }
            return Json(car);
        }


        [HttpPost]
        [ProducesResponseType(200, Type = typeof(List<Car>))]
        [Route("api/InsertCar")]
        public async Task<IActionResult> Post([FromBody]Car car)
        {
            if(await _icarservices.CarSaveAsync(car))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Unable To Insert New Car Data");
            }
        }


        [HttpDelete("{id:int}")]
        [Route("api/DeleteCar")]
        public async Task<ActionResult> Delete(int id)
        {
            if (await _icarservices.DeleteCar(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Unable To Delete Car Data");
            }
        }


    }
}
