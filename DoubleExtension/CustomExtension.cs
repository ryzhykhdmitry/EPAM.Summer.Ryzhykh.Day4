using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleExtension
{
    /// <summary>
    /// Extends Double
    /// </summary>
    public static class CustomExtension
    {
        /// <summary>
        /// Allows to represent Double value as Bit
        /// </summary>
        /// <param name="value">Value thta we want to convert</param>
        /// <returns>String of bits</returns>
        public static string ToBit(this double value)
        {
            StringBuilder result = new StringBuilder();
            byte[] bytesArray = BitConverter.GetBytes(value);
            BitArray bitsArray = new BitArray(bytesArray);

            for (int i = 0; i < 64; i++)
            {
                if (bitsArray[i])
                {
                    result.Insert(0, 1);
                }
                else
                {
                    result.Insert(0, 0);
                }
            }

            return result.ToString();
        }
    }
}

