using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public class Foot : Distance<Foot>
    {
        public Foot()
            : this (0.0)
        {

        }

        public static implicit operator Foot(double value)
        {
            return new Foot(value);
        }

        public Foot(double value)
        {
            this.Factor = Factors.MetersPerFoot;
            this.Label = "Feet";
            this.Symbol = "ft";
            this.Value = value;
        }
    }
}
