using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Kilogram : Mass<Kilogram>
    {
        public Kilogram()
            : this(0.0)
        {

        }

        public Kilogram(IMass mass)
            : this(mass.To<Kilogram>().Value)
        {

        }

        public Kilogram(double value)
        {
            this.Factor = Factors.Kilogram;
            this.Label = "Kilograms";
            this.Symbol = "kg";
            this.Value = value;
        }

        public static implicit operator Kilogram(double value)
        {
            return new Kilogram(value);
        }
    }
}
