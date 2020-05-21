﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCar.Data.Requests.Vehicle
{
    public class VehicleSearchRequest
    {
        public string RegistrationNumber { get; set; }
        public string ManufacturerName { get; set; }
        public string BranchName { get; set; }
    }
}