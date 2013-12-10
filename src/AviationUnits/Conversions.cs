using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    internal static class Conversions
    {
        public static T FactorConvert<T>(this IUnit current)
            where T : IUnit, new()
        {
            T obj = new T();

            if (typeof(T) == obj.BaseUnit)
                obj.Value = current.BaseUnitValue * obj.Factor; // converting to base unit
            else
                obj.Value = current.BaseUnitValue / obj.Factor; // converting out of base unit
            
            return obj;
        }

        public static T TemperatureConvert<T>(this ITemperature current)
            where T : ITemperature, new()
        {
            T obj = new T();

            // if conversion of same types
            if (current.GetType() == typeof(T))
                obj.Value = current.Value;


            // converting to kelvin
            if (obj.GetType() == typeof(Kelvin))
                obj.Value = current.GetType() == typeof(Celsius) ? current.Value + 273.15 : (current.Value + 459.67) * (5.0/9.0);

            // converting to Celcius
            if (obj.GetType() == typeof(Celsius))
                obj.Value = current.GetType() == typeof(Kelvin) ? current.Value - 273.15 : (current.Value - 32) * (5.0/9.0);

            if (obj.GetType() == typeof(Fahrenheit))
                obj.Value = current.GetType() == typeof(Kelvin) ? ((current.Value * (9.0/5.0)) - 459.67) : (current.Value * (9.0/5.0) + 32);

            // Automatically round to 2 precicision points
            obj.Value = Math.Round(obj.Value, 2);

            return obj;                
        }
    }

    public static class ConversionExtensions
    {
        public static T To<T>(this IAngle current)
            where T : IAngle, new()
        {
            return current.FactorConvert<T>();
        }

        public static T To<T>(this IDistance current)
            where T : IDistance, new()
        {
            return current.FactorConvert<T>();
        }

        public static T To<T>(this IMass current)
            where T : IMass, new()
        {
            return current.FactorConvert<T>();
        }

        public static T To<T>(this IPressure current)
            where T : IPressure, new()
        {
            return current.FactorConvert<T>();
        }

        public static T To<T>(this ISpeed current)
            where T : ISpeed, new()
        {
            return current.FactorConvert<T>();
        }

        public static T To<T>(this ITemperature current)
            where T : ITemperature, new()
        {
            return current.TemperatureConvert<T>();
        }

        public static T To<T>(this IVolume current)
            where T : IVolume, new()
        {
            return current.FactorConvert<T>();
        }
    }
}
