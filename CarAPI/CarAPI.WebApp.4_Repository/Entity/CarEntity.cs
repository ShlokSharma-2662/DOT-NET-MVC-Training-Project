using CarAPI.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.WebApp._4_Repository.Entity
{
    public class CarEntity
    {

        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarManufacturer { get; set; }
        public  short? CarColor { get; set; }
        public string? CarLaunchDate { get; set; }

    }
}
