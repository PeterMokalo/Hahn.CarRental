using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Domain.Models
{
    public static class RentalStatusModel
    {
        public const string InProgress = "INPROGRESS";
        public const string Booked = "BOOKED";
        public const string Completed = "COMPLETED";
        public const string Cancelled = "CANCELLED";
        public const string Pending = "PENDING";
    }
    public static class CarStatusModel
    {
        public const string Available = "AVAILABLE";
        public const string Booked = "BOOKED";
        public const string Maintenance = "MAINTENANCE";
        public const string Retired = "RETIRED";
    }
    public static class StaffTypeModel
    {
        public const string Admin = "ADMIN";
        public const string Driver = "DRIVER";
    }
    public static class FulfillmentTypeModel
    {
        public const string Delivery = "DELIVERY";
        public const string Pickup = "PICKUP";
        public const string ToBeDetermined = "TBD";
    }
}
