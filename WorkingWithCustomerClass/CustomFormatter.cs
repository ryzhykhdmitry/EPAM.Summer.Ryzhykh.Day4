using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCustomerClass
{
    /// <summary>
    /// Custom formater.
    /// </summary>
    public class CustomerFormatter : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// Allows to get format.
        /// </summary>
        /// <param name="formatType">Type of the format.</param>
        /// <returns>Object.</returns>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }

        /// <summary>
        /// Changing format.
        /// </summary>
        /// <param name="format">Name of the format.</param>
        /// <param name="arg">Argument.</param>
        /// <param name="formatProvider">Provider.</param>
        /// <returns>Formated string.</returns>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
                format = "N";
            format = format.ToUpper();
            switch (format)
            {
                case "P":
                    {
                        string customerString = arg.ToString();
                        customerString = customerString.Replace(" ", "");
                        customerString = customerString.Replace("-", "");
                        customerString = customerString.Replace("(", "");
                        customerString = customerString.Replace(")", "");
                        return customerString.Substring(0, 2) + " (" + customerString.Substring(2, 3) + ") " + customerString.Substring(5, 3) + " " + customerString.Substring(8, 2) + " " + customerString.Substring(10, 2);
                    }
                case "N":
                    return (arg as string).ToUpper();
                case "N2":
                    return String.Format(CultureInfo.CurrentCulture, "{0:F2}", arg);
                default:
                    throw new FormatException(String.Format("The '{0}' format specifier is not supported.", format));
            }
        }
    }
}
