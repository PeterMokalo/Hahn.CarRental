using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class Staff : Person
    {
        [Required]
        [StringLength(20)]
        public string StaffType { get; set; } 

        public ICollection<RentalDelivery> RentalDeliveries { get; set; } 
        public ICollection<RentalCompletion> RentalCompletions { get; set; } 
        
    }
}
