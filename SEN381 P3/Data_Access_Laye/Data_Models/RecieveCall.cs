using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class RecieveCall : Ticketing
    {
        public override void execute(Job job)
        {
            Console.WriteLine("Reciving call...");
        }
    }
}
