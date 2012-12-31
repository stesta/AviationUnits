using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class InchesOfMercury : Pressure<InchesOfMercury>
    {
        public InchesOfMercury()
            : this(0.0)
        {

        }

        public InchesOfMercury(IPressure pressure)
            : this(pressure.To<InchesOfMercury>().Value)
        {

        }

        public InchesOfMercury(double value)
        {
            this.Factor = Factors.InchesOfMercury;
            this.Label = "\" of Mercury";
            this.Symbol = "\" of Mercury";
            this.Value = value;
        }

        public static implicit operator InchesOfMercury(double value)
        {
            return new InchesOfMercury(value);
        }
    }
}
