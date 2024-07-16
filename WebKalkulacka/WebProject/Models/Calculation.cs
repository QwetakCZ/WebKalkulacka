using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }

        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }

    }
}
