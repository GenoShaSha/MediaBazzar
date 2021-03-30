using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ_PCBS04_G3
{
    public class BSNException : Exception
    {
        public BSNException(string givenBSN) : base($"Provided BSN {givenBSN} not in the correct format! It should has 10 digits e.g. 3041934193")
        {

        }
    }
}
