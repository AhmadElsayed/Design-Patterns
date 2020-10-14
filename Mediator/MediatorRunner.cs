using DesignPatternsCore.Mediator;

namespace DesignPatternsCore
{
    /// <summary>
    /// #Motivation
    /// Here, we will define two participants and the mediator, The action is to send an event from the Alarm "AlarmSnooze"
    /// When that command received from the Mediator, It will send a request to the coffee machine to start brewing coffee
    /// for more explanation visit: 
    /// https://www.linkedin.com/pulse/design-patterns-newbies-01-mediator-pattern-ahmed-elsayed/?published=t
    /// 
    /// #Solution
    ///     1. Implement the interface Imediator
    ///     2. Implement the concrete mediator class.
    ///     3. Implement the base class for the Participant.
    ///     4. Implement our main two participants CoffeeMaker and Alarm
    ///     5. All the business logic and mapping between events should be included within the mediator Notify function
    ///     6. You're Done !
    /// </summary>
    public class MediatorRunner : IPattern
    {
        public void Test()
        {
            Participant coffeeMachine = new CoffeeMachine();
            Participant alarm = new Alarm();

            IMediator mediator = new Mediator.Mediator(alarm, coffeeMachine);

            alarm.SendMessage("AlarmSnooze");
        }
    }
}
