using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.DTO.Common
{
    public abstract class PersonDto : BaseDto
    {
        //[Required]
        //[MaxLength(50)]
        public string FirstName { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string LastName { get; set; }
        //[Required]
        //[MaxLength(200)]
        public string EmailAddress { get; set; }
        //[Required]
        //[MaxLength(20)]
        public string PhoneNumber { get; set; }
        
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
