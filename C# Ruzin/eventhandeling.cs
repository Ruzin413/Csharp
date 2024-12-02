using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class eventhandeling
    {
    }
    public class Publisher
    {
        public event EventHandler myEvent;

        public void RaiseEvent()
        {
            Console.WriteLine("Event is about to be raised!");
            myEvent?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Subscriber
    {
        public void OnMyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event received and handled");
        }
    }
}
