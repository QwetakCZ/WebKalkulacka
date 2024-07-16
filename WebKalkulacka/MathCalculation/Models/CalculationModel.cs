using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalculation.Models
{
    public class CalculationModel
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public Operation? Operation { get; set; }
        public double Result { get; set; }
    }

    public enum Operation 
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }
}
