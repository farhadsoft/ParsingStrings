using System;

namespace ParsingStrings
{
    public static class FloatingPointParser
    {
        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string representing a number to convert.</param>
        /// <param name="result">When this method returns, contains single-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseFloat(string str, out float result)
        {
            try
            {
                return float.TryParse(str, out result);
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A single-precision floating-point number equivalent to the numeric str or symbol specified in <paramref name="str"/>.  If a formatting error occurs returns NaN. </returns>
        public static float ParseFloat(string str)
        {
            try
            {
                return float.Parse(str);
            }
            catch (FormatException)
            {
                return float.NaN;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(str));
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string representing a number to convert.</param>
        /// <param name="result">When this method returns, contains double-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseDouble(string str, out double result)
        {
            try
            {
                return double.TryParse(str, out result);
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A double-precision floating-point number equivalent to the numeric str or symbol specified in <paramref name="str"/>. If a formatting error occurs returns Epsilon.</returns>
        public static double ParseDouble(string str)
        {
            try
            {
                return double.Parse(str);
            }
            catch (FormatException)
            {
                return double.Epsilon;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(str));
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        /// <param name="str">The string representation of the number to convert.</param>
        /// <param name="result">When this method returns, contains the Decimal number that is equivalent to the numeric value contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseDecimal(string str, out decimal result)
        {
            try
            {
                return decimal.TryParse(str, out result);
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        /// <param name="str">The string representation of the number to convert.</param>
        /// <returns>The equivalent to the number contained in <paramref name="str"/>.</returns>
        public static decimal ParseDecimal(string str)
        {
            try
            {
                return decimal.Parse(str);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException(nameof(str));
            }
            catch (OverflowException)
            {
                return -2.2m;
            }
            catch (Exception)
            {
                return -1.1m;
            }
        }
    }
}
