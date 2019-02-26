using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarLookupCodeFirst.Data.Models
{
    public class BodyType
    {
        public BodyType()
        {
            Cars = new List<Car>();
        }

        public virtual ICollection<Car> Cars { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
