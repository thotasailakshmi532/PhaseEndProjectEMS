﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhaseEndProjectEMS.Models
{
    public class EmpProfileModel
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public int DeptCode { get; set; }

    }
}