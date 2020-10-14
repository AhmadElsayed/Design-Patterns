using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.Mediator
{
    public class Alarm : Participant
    {
        public override void SendMessage(string Message)
        {
            Console.WriteLine($"Message from Alarm, an event {Message} has just occured");
            // Here, the action AlaramSnooze is one of the actions required by the Mediator
            if (Message == "AlarmSnooze")
            {
                _mediator.Notify(this, Message);
            }
            else
                throw new NotImplementedException("This case is not included");
        }
    }
}
