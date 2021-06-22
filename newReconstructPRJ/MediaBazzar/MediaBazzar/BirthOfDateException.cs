using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class BirthOfDateException : Exception
    {
        public BirthOfDateException()
            : base("Employee must be 18 or older to legally work!")
        {

        }

        public BirthOfDateException(DateTime datetime)
            : base(String.Format("Invalid age for work : {0}", datetime.ToShortDateString()))
        {

        }
    }

}
