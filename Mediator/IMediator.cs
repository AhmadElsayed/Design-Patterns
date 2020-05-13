using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// The interface of the IMediator
    /// It will have two functions
    /// 1. Add Participant => For adding new actor in the loop
    /// 2. Notify => It will be used to handle events received from other members
    /// </summary>
    public interface IMediator
    {
        void Notify(Participant sender, string message);
    }
}
