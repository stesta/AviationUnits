using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    public class Kilogram : Mass<Kilogram>
    {
        public Kilogram()
            : this(0.0)
        {

        }

        public static implicit operator Kilogram(double value)
        {
            return new Kilogram(value);
        }

        public Kilogram(double value)
        {
            this.Factor = Factors.Kilogram;
            this.Label = "Kilograms";
            this.Symbol = "kg";
            this.Value = value;
        }
    }
}
