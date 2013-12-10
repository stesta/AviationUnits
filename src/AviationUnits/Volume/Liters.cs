using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Liters : Volume<Liters>
    {
        public Liters()
            : this(0.0)
        {

        }

        public Liters(IVolume volume)
            : this(volume.To<Liters>().Value)
        {

        }

        public Liters(double value)
        {
            this.Factor = Factors.Liter;
            this.Label = "Liters";
            this.Symbol = "l";
            this.Value = value;
        }

        public static implicit operator Liters(double value)
        {
            return new Liters(value);
        }
    }
}
