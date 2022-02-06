using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class Car : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Model { get; set; }
        [Required]
        [MaxLength(50)]
        public string Manufacturer { get; set; }
        [Required]
        [StringLength(4)]
        public string Year { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Status { get; set; } = CarStatusModel.Available;
        [Required(ErrorMessage = "Hour Rate is required")]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal HourRate { get; set; }
        [Required(ErrorMessage = "Late Hour Rate is required")]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LateHourRate { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
