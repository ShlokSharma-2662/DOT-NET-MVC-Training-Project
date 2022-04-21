using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAPI.Common.Enum;

namespace CarAPI.Common.Models
    
{
    public class Car
    {
        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarManufacturer { get; set; }
        public CarColor? CarColor { get; set; }
        public string? CarLaunchDate { get; set; }


    }
}
