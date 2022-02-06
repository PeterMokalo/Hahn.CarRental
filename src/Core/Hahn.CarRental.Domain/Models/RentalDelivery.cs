using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class RentalDelivery : BaseEntity
    {
        public DateTime DeliveryDateTime { get; set; }


        [ForeignKey("Rental")]
        public int RentalId { get; set; }
        public Rental Rental { get; set; }

        [ForeignKey("Staff")]
        [Column("DeliveryStaffId")]
        public int StaffId { get; set; }

        public Staff Staff { get; set; }
    }
}
