using Hahn.CarRental.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.DTO.Users
{
    internal class StaffDto : PersonDto
    {
        public string StaffType { get; set; }
    }
}
