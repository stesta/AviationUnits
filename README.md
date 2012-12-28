Aviation Units
---------------


Aviation Units is a simple unit library to aid in aviation calculations and conversions. The library is built as a Portable Class Library so it can be used across many different application types and frameworks. Requires .NET 4.0 or higher.

Usage
-----
    KilometersPerHour kph = 120;
    
    // Manually convert km/h to mph
    var mph = kph.To<MilesPerHour>();

    // or use an implicit conversion of km/h to mph
    MilesPerHour mph = kph;

    // Perform mathematical operations on units of different types 
    // Results are converted to a default base unit, in this case km/h
    var sum = kph + mph;
