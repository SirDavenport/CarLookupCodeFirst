using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarLookupCodeFirst.Data.Models
{
    public class CarBodyType
    {
        public virtual BodyType BodyType { get; set; }

        [ForeignKey("BodyType")]
        public int BodyTypeID { get; set; }

        public virtual Car Car { get; set; }

        [ForeignKey("Car")]
        public int CarID { get; set; }

        [Key]
        public int ID { get; set; }
    }
}
