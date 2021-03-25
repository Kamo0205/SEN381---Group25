using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    enum MyEnum
    {

    }
    public class ClientEditor : Editor
    {
        public object[] Add(List<object> objects, object obj)
        {
            objects.Add(obj);
            return objects.ToArray();
        }

        public object[] Remove(List<object> objects, object obj)
        {
            throw new NotImplementedException();
        }

        public object[] search(List<object> objects, int[] options, string[] terms)
        {
            List<object> results = new List<object>();
            foreach (object client in objects)
            {
                
            }
            return objects.ToArray();
        }

        public object[] Update(List<object> objects, object obj)
        {
            foreach (object client in objects)
            {
                Client client1 = (Client)client;
                if (((Client) client).Equals((Client)obj))
                {
                    client1 = (Client)obj;
                }
            }
            return objects.ToArray();
        }
    }
}
