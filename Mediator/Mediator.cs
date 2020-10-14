using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.Mediator
{
    /// <summary>
    /// The concrete implementation for the Mediator
    /// </summary>
    public class Mediator : IMediator
    {
        Participant alarm;
        Participant coffeeMachine;

        public Mediator(Participant alarm, Participant coffeeMachine)
        {
            this.alarm = alarm;
            alarm.SetMediator(this);
            this.coffeeMachine = coffeeMachine;
            coffeeMachine.SetMediator(this);
        }

        public void Notify(Participant sender, string message)
        {
            if (message == "AlarmSnooze")
            {
                Console.WriteLine("Message from Mediator, I received an event from Alaram, The request has been sent to the coffee machine");
                this.coffeeMachine.SendMessage("MakeCoffee");
            }
            
        }
    }
}
