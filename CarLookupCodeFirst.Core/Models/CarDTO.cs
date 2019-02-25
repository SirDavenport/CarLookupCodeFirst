using System.Collections.Generic;

namespace CarLookupCodeFirst.Core.Models
{
    public class CarDTO
    {
        public ICollection<string> BodyTypeNames { get; set; }
        public int ID { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
