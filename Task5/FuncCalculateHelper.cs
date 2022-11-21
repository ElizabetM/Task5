using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class FuncCalculateHelper
    {
        public double Fact(double value)
        {
            if ((int)value < 2)
                return 1;

            return (int)value * Fact((int)value - 1);
        }

        public double DevisionTo100(double value)
            => IsNaN(value) ? double.NaN : value / 100.0;

        //логариф по основанию e
        public double Ln(double value)
            => IsNaN(value) ? double.NaN : Math.Log(value);

        public double DoubleLn(double value)
            => IsNaN(value) ? double.NaN : value * 2.0;
        
        public double Exponenta(double value)
            => Math.Exp(value);

        public double Multiple(double value1, double value2)
            => value1 * value2;

        public double CalculateY(double x)
            => Multiple(Fact(x), Exponenta(DoubleLn(Ln(DevisionTo100(x)))));

        private bool IsNaN(double value)
            => double.IsInfinity(value) || double.IsNaN(value);
    }
}
