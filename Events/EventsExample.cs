using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Events
{
    internal static class EventsExample
    {
        internal static void Run()
        {
            //The emitter will fire a message to the subscriber object, this is an example of Events and Delegates
            EventEmitter emitter = new EventEmitter();
            Subscriber subscriber = new Subscriber(emitter);
            emitter.RaiseEvent("This is a message from an EventEmitter object");
        }
    }
}
