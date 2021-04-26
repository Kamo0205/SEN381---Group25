using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Pay
    {
        private string title;
        private float amount;

        public string Title { get => title; set => title = value; }
        public float Amount { get => amount; set => amount = value; }

        public Pay(string title, float amount)
        {
            this.title = title;
            this.amount = amount;
        }

        public override string ToString()
        {
            return string.Format(@"Title: {0}\nAmount: {1}", Title, Amount);
        }
    }
}
