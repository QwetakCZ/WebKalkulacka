using System.ComponentModel.DataAnnotations;
using MathCalculation.Models;

namespace WebProject.Models
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }

        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public Operation Operation { get; set; }
        public double Result { get; set; }

    }
}
