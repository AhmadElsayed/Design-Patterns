using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.Mediator
{
    /// <summary>
    /// All the participants (members) will inherit from this bsae class
    /// SendMessage is used to receive the commands from the Mediator
    /// </summary>
    public abstract class Participant
    {
        protected IMediator _mediator;

        public void SetMediator(IMediator mediator) {
            _mediator = mediator;
        }

        public abstract void SendMessage(string Message);
    }
}
