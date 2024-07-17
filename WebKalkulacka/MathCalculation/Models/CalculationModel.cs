using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculation.Models
{
    public class CalculationModel
    {
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public Operation? Operation { get; set; }
        public decimal Result { get; set; }
    }

    public enum Operation 
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }
}
