using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
    /// <summary>
    /// Custom exceptions were used, to make errors expressive and
    /// avoid relying on strings only. As classes/objects, they also
    /// allow more extensibility and encapsulation than strings.
    /// </summary>
    public class TooHighException : Exception
    {
        public TooHighException(string message) : base(message)
        {
        }
    }

    public class TooLowException : Exception
    {
        public TooLowException(string message) : base(message)
        {
        }
    }
}
