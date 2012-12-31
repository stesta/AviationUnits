using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Volume<T> : Unit<IVolume>, IVolume
        where T : IVolume
    {
        public override Type BaseUnit { get { return typeof(Liters); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        //
        // Operators

        public static implicit operator double(Volume<T> v)
        {
            return v.Value;
        }

        public static Liters operator +(Volume<T> v1, IVolume v2)
        {
            return new Liters((v1.BaseUnitValue + v2.BaseUnitValue));
        }

        public static Liters operator -(Volume<T> v1, IVolume v2)
        {
            return new Liters((v1.BaseUnitValue - v2.BaseUnitValue));
        }

        public static Liters operator *(Volume<T> v1, IVolume v2)
        {
            return new Liters((v1.BaseUnitValue * v2.BaseUnitValue));
        }

        public static Liters operator /(Volume<T> v1, IVolume v2)
        {
            if (v2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new Liters((v1.BaseUnitValue / v2.BaseUnitValue));
        }
    }
}
