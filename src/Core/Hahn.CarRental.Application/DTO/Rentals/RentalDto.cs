using Hahn.CarRental.Application.DTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.DTO.Rentals
{
    internal class RentalDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RentalStatus { get; set; }
        public string DeliveryAddress { get; set; }
        public int NumberOfHours { get; set; }
        public string FulfillmentType { get; set; }

        //Delivery
        public DateTime DeliveryDateTime { get; set; }
        public int DeliveryStaffId { get; set; }

        //Completion
        public DateTime ReturnDateTime { get; set; }
        public int ActualNumberOfHours { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal LateFee { get; set; }
        public decimal TotalAmountPayable { get; set; }
        public DateTime CompletionDate { get; set; }
        public int CompletionStaffId { get; set; }
    }
}
