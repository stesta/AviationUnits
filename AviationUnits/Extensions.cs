using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    // internal only, units must be converted to an applicable type 
    internal static class UnitExtension
    {
        public static T Convert<T>(this IUnit current)
            where T : IUnit, new()
        {
            T obj = new T();

            if (typeof(T) == obj.BaseUnit) // converting to base unit
                obj.Value = current.BaseUnitValue * obj.Factor;
            else    // converting out of base unit
                obj.Value = current.BaseUnitValue / obj.Factor;

            return obj;
        }
    }

    // This is done to group by interface for conversion
    public static class Extensions
    {
        public static T To<T>(this IAngle current)
            where T : IAngle, new()
        {
            return current.Convert<T>();
        }

        public static T To<T>(this IDistance current)
            where T : IDistance, new()
        {
            return current.Convert<T>();
        }

        public static T To<T>(this IMass current)
            where T : IMass, new()
        {
            return current.Convert<T>();
        }

        public static T To<T>(this ISpeed current)
            where T : ISpeed, new()
        {
            return current.Convert<T>();
        }
    }
}
