using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public interface Editor
    {
        object[] Add(List<object> objects, object obj);
        object[] Update(List<object> objects, object obj);
        object[] Remove(List<object> objects, object obj);
        object[] search(List<object> objects, int[] options, string[] terms);
    }
}
