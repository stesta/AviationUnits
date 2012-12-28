using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Angle<T> : Unit<IAngle>, IAngle
        where T : class, IAngle
    {
        public override Type BaseUnit { get { return typeof(Radian); } }

        public static implicit operator double(Angle<T> a)
        {
            return a.Value;
        }

        public static Radian operator +(Angle<T> a1, IAngle a2)
        {
            return new Radian((a1.BaseUnitValue + a2.BaseUnitValue));
        }

        public static Radian operator -(Angle<T> a1, IDistance a2)
        {
            return new Radian((a1.BaseUnitValue - a2.Value));
        }
    }


}
