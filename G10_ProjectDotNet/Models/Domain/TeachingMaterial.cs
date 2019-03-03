﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Models.Domain
{
    public class TeachingMaterial
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public TypeOfExcersize Type { get; set; }
        public DateTime LastConsultation { get; set; }
        public int TotalConsultations { get; set; }
    }
}
