﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookupCodeFirst.Models
{
    public class Car
    {
        public virtual ICollection<BodyType> BodyTypes { get; set; }
        public int ID { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
