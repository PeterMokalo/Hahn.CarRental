using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class Rental : BaseEntity
    {
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        [MaxLength(15)]
        public string RentalStatus { get; set; } = RentalStatusModel.Pending;
        [MaxLength(250)]
        public string DeliveryAddress { get; set; }
        [Required]
        public int NumberOfHours { get; set; }
        [Required]
        [MaxLength(25)]
        public string FulfillmentType { get; set; } = FulfillmentTypeModel.ToBeDetermined;


        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }


        [ForeignKey("User")]
        [Column("RequestingUserId")]
        public int UserId { get; set; }
        public User User { get; set; }


        //[ForeignKey("RentalDelivery")]
        //public int? RentalDeliveryId { get; set; }
        public RentalDelivery RentalDelivery { get; set; }


        //[ForeignKey("RentalCompletion")]
        //public int? RentalCompletionId { get; set; }
        public RentalCompletion RentalCompletion { get; set; }

    }
}
