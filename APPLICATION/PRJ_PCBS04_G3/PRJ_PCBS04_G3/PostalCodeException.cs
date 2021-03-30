using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_PCBS04_G3
{
    public class PostalCodeException : Exception
    {
        public PostalCodeException(string givenPostalCode) : base($"Provided Postal Code {givenPostalCode} not in the correct format! It should has 4 digits and 2 letters e.g. 5641PP")
        {

        }
    }
}
