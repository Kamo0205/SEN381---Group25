using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer
{
    public class TicketingContext
    {
        private Ticketing _state;
        private Job job;

        public Ticketing State { get => _state; set => _state = value; }
        public Job Job { get => job; set => job = value; }

        public TicketingContext(Ticketing state, Job job)
        {
            this.change_to(state);
            this.job = job;
        }

        public void change_to(Ticketing state)
        {
            this._state = state;
            this._state.Context = this;
        }

        public void execute()
        {
            this._state.execute(this.job);
        }
    }
}
