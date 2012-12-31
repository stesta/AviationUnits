using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Kilograms : Mass<Kilograms>
    {
        public Kilograms()
            : this(0.0)
        {

        }

        public Kilograms(IMass mass)
            : this(mass.To<Kilograms>().Value)
        {

        }

        public Kilograms(double value)
        {
            this.Factor = Factors.Kilogram;
            this.Label = "Kilograms";
            this.Symbol = "kg";
            this.Value = value;
        }

        public static implicit operator Kilograms(double value)
        {
            return new Kilograms(value);
        }
    }
}
