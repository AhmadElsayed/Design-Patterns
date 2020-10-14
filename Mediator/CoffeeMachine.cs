using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.Mediator
{
    public class CoffeeMachine : Participant
    {
        public override void SendMessage(string Message)
        {
            if (Message == "MakeCoffee")
                Console.WriteLine("Message from Coffee Machine, Preparing!");
        }
    }
}
