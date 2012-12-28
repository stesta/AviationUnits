using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Distance<T> : Unit<IDistance>, IDistance
        where T : IDistance
    {
        public override Type BaseUnit { get { return typeof(Meter); } }

        public static implicit operator double(Distance<T> d)
        {
            return d.Value;
        }

        public static Meter operator +(Distance<T> d1, IDistance d2) 
        {
            return new Meter((d1.BaseUnitValue + d2.BaseUnitValue));
        }

        public static Meter operator -(Distance<T> d1, IDistance d2)
        {
            return new Meter((d1.BaseUnitValue - d2.Value));
        }
    }
}
