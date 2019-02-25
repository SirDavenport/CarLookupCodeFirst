﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookupCodeFirst.Data.Models
{
    public class Car
    {
        public ICollection<string> BodyTypeNames { get; set; }
        public int ID { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
