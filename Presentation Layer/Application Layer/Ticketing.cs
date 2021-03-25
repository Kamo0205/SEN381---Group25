using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public abstract class Ticketing
    {
        private TicketingContext context;

        public TicketingContext Context { get => context; set => context = value; }

        public abstract void execute(Job job);
    }
}
