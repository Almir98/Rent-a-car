﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Booking
{
    public class BookingRequest
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
    }
}