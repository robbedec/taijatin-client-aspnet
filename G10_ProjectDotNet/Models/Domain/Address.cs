﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Models.Domain
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Bus { get; set; }
    }
}
