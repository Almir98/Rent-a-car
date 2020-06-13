﻿using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int NumberOfDays { get; set; }
        public double? TotalPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Canceled { get; set; }
        public int? Discount { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }

        public  Customer Customer { get; set; }
        public  Vehicle Vehicle { get; set; }
        public  ICollection<Payment> Payment { get; set; }
    }
}