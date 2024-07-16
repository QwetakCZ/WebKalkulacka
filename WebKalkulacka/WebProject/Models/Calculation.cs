using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class Calculation
    {
        [Key]
        public int Id { get; set; }

        public double[] Numbers { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }

    }
}
