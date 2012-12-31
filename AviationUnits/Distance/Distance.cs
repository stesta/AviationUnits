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
        public override Type BaseUnit { get { return typeof(Meters); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        //
        // Operators

        public static implicit operator double(Distance<T> d)
        {
            return d.Value;
        }

        public static Meters operator +(Distance<T> d1, IDistance d2) 
        {
            return new Meters((d1.BaseUnitValue + d2.BaseUnitValue));
        }

        public static Meters operator -(Distance<T> d1, IDistance d2)
        {
            return new Meters((d1.BaseUnitValue - d2.BaseUnitValue));
        }

        public static Meters operator *(Distance<T> d1, IDistance d2)
        {
            return new Meters((d1.BaseUnitValue * d2.BaseUnitValue));
        }

        public static Meters operator /(Distance<T> d1, IDistance d2)
        {
            if (d2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new Meters((d1.BaseUnitValue / d2.BaseUnitValue));
        }
    }
}
