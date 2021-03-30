using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterfall_PRJ
{
    public class BirthDateException : Exception
    {
        public BirthDateException()
            : base("Employee must be 18 or older to legally work!")
        {

        }

        public BirthDateException(DateTime datetime)
            : base(String.Format("Invalid age for work : {0}", datetime.ToShortDateString()))
        {

        }
    }
}
