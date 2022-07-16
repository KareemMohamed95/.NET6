using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Events
{
    internal class Subscriber
    {
        public Subscriber(EventEmitter emitter)
        {
            emitter.Event += OnMessageReceived;
        }
        void OnMessageReceived(object? sender, Args e)
        {
            if(sender is EventEmitter)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
