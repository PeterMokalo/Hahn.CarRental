using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public class RentalCompletion : BaseEntity
    {
        public DateTime ReturnDateTime { get; set; }
        public int ActualNumberOfHours { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal RentalAmount { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal LateFee { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TotalAmountPayable { get; set; }
        public DateTime CompletionDate { get; set; }


        [ForeignKey("Rental")]
        public int RentalId { get; set; }
        public Rental Rental { get; set; }


        [ForeignKey("Staff")]
        [Column("CompletionStaffId")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
