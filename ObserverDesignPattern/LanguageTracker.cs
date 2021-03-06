﻿using System;
using System.Collections.Generic;

namespace DesignPatternsCore.ObserverDesignPattern
{
    /// <summary>
    /// #Motivation
    /// Using this pattern i can track a specific Proprty to do action or change a specific behavior depending on it
    /// 
    /// #Structure
    /// IObserver::LanguageObserver
    ///     -> Need the Tracker object in the constructor
    ///     -> Update function that will be called each change
    /// ITracker::LanguageTracker
    ///     -> List(Observers): A list of observers that i need to update each change
    ///     -> RegisterObserver: Will be called from the Observer constructor.
    ///     -> RemoveObserver: Delete an Observer from the observers list
    /// 
    /// #Sample Problem
    /// I have a solution that mainly depending on the user language, and i need to keep tracking this language to change UI language and 
    /// do a lot of other multiple business that implements the IObserver interface
    /// Doing this by the old way require that i will need to a static defined list of jobs that will be fired manually each change on the language object
    /// 
    /// #Solution
    ///     1. Implement the IObserver interface containing the Update function that i need to execute each change.
    ///     2. Implement the ITracker interface with Registering, Deleting Observers.
    ///     3. When the Observer object initialized by another object of Tracker, This Observer will be added to the Observers list in the Tracker object.
    ///     4. When we call the Set____ function in the tracker, it calls the NotifyObservers function
    ///     5. The Notify Observers by its role, loop at all the Observers and call the Update method with the new value of the changed property.
    ///     6. The Update function in each observer do its job depending on its new value.
    /// </summary>
    internal class LanguageTracker : ITracker
    {
        /// <summary>
        /// A list of observers that i need to update each change
        /// </summary>
        private readonly List<IObserver> _observers = new List<IObserver>();

        /// <summary>
        /// Dummy object to be changed, Change this one later on your code depending on your business
        /// </summary>
        private EnumLanguage _currentLanguage;
        
        /// <summary>
        /// Loop in all observers and Update them with the new changed property
        /// </summary>
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_currentLanguage);
            }
        }

        /// <summary>
        /// The Set function that will Fire all the events waiting in all Observers
        /// </summary>
        /// <param name="lang">The same dummy object declared above</param>
        public void SetCurrentLang(EnumLanguage lang)
        {
            this._currentLanguage = lang;
            NotifyObserver();
        }

        /// <summary>
        /// Add a new observer to the observers list
        /// </summary>
        /// <param name="observer"></param>
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Observer Added");
        }

        /// <summary>
        /// Remove a specific observer from the observers list
        /// </summary>
        /// <param name="observer">The lucky observer that will be free</param>
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Observer Deleted");
        }
    }
}
