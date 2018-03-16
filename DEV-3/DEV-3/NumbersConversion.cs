using System;
using System.Numerics;
using System.Text;

namespace DEV_3
{
    /// <summary>
    /// Conversion a number to the selected number system
    /// </summary>
    class NumbersConversion
    {
        int decimalNumber;
        int scaleOfNotation;
        public NumbersConversion (int arg1, int arg2)
        {
            decimalNumber = arg1;
            scaleOfNotation = arg2;
        }

        /// <summary>
        /// Conversion a number to the selected number system
        /// </summary>
        /// <returns> Converted number</returns>
        public string ConversionToRadix()
        {
            StringBuilder convertedNumber = new StringBuilder();
            while (decimalNumber > 0)
            {
                convertedNumber.Insert(0, GetPartOfNumber((int)(decimalNumber % scaleOfNotation)));
                decimalNumber /= scaleOfNotation; 
            }
            return convertedNumber.ToString();
        }

        private char GetPartOfNumber(int numberOfSymbol)
        {
            string allSymbols = "0123456789ABCDEFGHIJ";
            return allSymbols[numberOfSymbol];
        }
    }
}
