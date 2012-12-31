using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AviationUnits
{
    internal static class Factors
    {
        //
        // Angle

        public static double Radian = 1;
        public static double RadiansPerDegree = Math.PI / 180.0;
        public static double RadiansPerMinute = RadiansPerDegree / 60.0;
        public static double RadiansPerSecond = RadiansPerMinute / 60.0;

        //
        // Distance

        public static double Meter { get { return 1; } }
        public static double Kilometer { get { return 1.0e3; } }
        public static double MetersPerInch { get { return 0.0254; } }
        public static double MetersPerFoot { get { return MetersPerInch * 12.0; } }
        public static double MetersPerYard { get { return MetersPerFoot * 3.0; } } 
        public static double MetersPerStatuteMile { get { return MetersPerYard * 1760.0; } }
        public static double MetersPerNauticalMile { get { return 1852.0; } }

        //
        // Mass

        public static double Kilogram { get { return 1; } }
        public static double KilogramsPerPound { get { return 0.453592; } }

        //
        // Pressure

        public static double InchesOfMercury { get { return 1; } }
        public static double InchesOfMercuryPerMillibar { get { return 0.029533; } }

        //
        // Speed

        public static double KilometersPerHour { get { return 1; } }
        public static double KilometersPerHourPerMilePerHour { get { return 1.609344; } }
        public static double KilometersPerHourPerKnot { get { return 1.852; } }

        //
        // Temperature

        public static double Kelvin { get { return 1; } }
        public static double Celcius { get { return 1; } }
        public static double Fahrenheit { get { return 1.8; } }

        //
        // Volume

        public static double Liter { get { return 1; } }
        public static double LitersPerUSGallon { get { return 3.785411784; } }
        public static double LitersPerImperialGallon { get { return 4.54609; } }
    }
}
