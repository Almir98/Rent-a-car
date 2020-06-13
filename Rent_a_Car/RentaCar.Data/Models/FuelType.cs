﻿using System;
using System.Collections.Generic;

namespace RentaCar.Data.Models
{
    public class FuelType
    {
        public int FuelTypeId { get; set; }
        public string FuelName { get; set; }

        public ICollection<Vehicle> Vehicle { get; set; }
    }
}