using System.ComponentModel.DataAnnotations;
using MathCalculation.Models;

namespace WebProject.Models
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }

        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public Operation Operation { get; set; }
        public decimal Result { get; set; }

    }
}
