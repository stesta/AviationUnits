using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Feet : Distance<Feet>
    {
        public Feet()
            : this (0.0)
        {

        }

        public Feet(IDistance distance)
            : this(distance.To<Feet>().Value)
        {

        }
        
        public Feet(double value)
        {
            this.Factor = Factors.MetersPerFoot;
            this.Label = "Feet";
            this.Symbol = "ft";
            this.Value = value;
        }

        public static implicit operator Feet(double value)
        {
            return new Feet(value);
        }
    }
}
