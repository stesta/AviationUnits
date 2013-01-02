using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits.Speed
{
    public class Mach : Speed<Mach>
    {
        public Mach()
            : this(0.0)
        {

        }

        public Mach(ISpeed speed)
            : this(speed.To<Knots>().Value)
        {

        }

        public Mach(double value)
        {
            this.Factor = Factors.KilometersPerHourPerMach;
            this.Label = "Mach";
            this.Symbol = "Mach";
            this.Value = value;
        }

        public static implicit operator Mach(double value)
        {
            return new Mach(value);
        }
    }
}
