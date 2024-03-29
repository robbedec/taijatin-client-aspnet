﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G10_ProjectDotNet.Models.Domain
{
    public class Attendance
    {
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
