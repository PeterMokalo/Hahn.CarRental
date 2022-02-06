using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class User : Person
    {
        [MaxLength(250)]
        public string Address { get; set; }


        public ICollection<Rental> Rentals { get; set; }
    }
}
