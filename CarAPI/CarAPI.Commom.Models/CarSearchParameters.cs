using CarAPI.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Common.Models
{
    public class CarSearchParameters
    {
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarManufacturer { get; set; }
        public CarColor? CarColor { get; set; }
        public string? CarLaunchDate { get; set; }


    }
}
