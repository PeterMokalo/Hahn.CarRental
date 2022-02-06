using Hahn.CarRental.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.DTO.Cars
{
    public class CarDto : BaseDto
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
        public decimal HourRate { get; set; }
        public decimal LateHourRate { get; set; }

    }
}
