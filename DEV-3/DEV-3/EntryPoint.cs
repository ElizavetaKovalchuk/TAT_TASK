using System;
using System.Collections.Generic;

namespace DEV_3
{
    /// <summary>
    /// It is entry point of the program and it is print a number in the selected number system
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            NumbersConversion enteredValues = new NumbersConversion(Int32.Parse(args[0]), Int32.Parse(args[1]));
            Console.WriteLine(enteredValues.ConversionToRadix());
        }
    }
}
