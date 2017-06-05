using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8240_Assignment1
{
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
