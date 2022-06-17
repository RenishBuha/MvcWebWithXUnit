using System.ComponentModel.DataAnnotations;

namespace MvcWebWithXUnit.Models
{
    public class AirthmeticModel
    {
        [Display(Name = "Number 1")]
        public int Number1 { get; set; }
        [Display(Name = "Number 2")]
        public int Number2 { get; set; }
        public double Result { get; set; }
    }
}
