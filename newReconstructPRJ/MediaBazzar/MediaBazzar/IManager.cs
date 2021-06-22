using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public interface IManager
    {
        void AddObj(Object obj);
        void RemoveObj(int id);
        List<object> GetListObj();
    }
}
