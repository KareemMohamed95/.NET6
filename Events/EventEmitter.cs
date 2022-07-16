using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Events
{
    internal class Args : EventArgs
    {
        public string? Message { get; set; }
    }
    internal class EventEmitter
    {
        public event EventHandler<Args>? Event = (_,_) => { };
        public void RaiseEvent(string Message)
        {
            Event?.Invoke(this, new Args() { Message = Message });
        }
    }
}
