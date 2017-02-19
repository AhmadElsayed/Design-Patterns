using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesignPattern
{
    class LanguageTracker : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        private enumLanguage _currentLanguage;
        
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_currentLanguage);
            }
        }

        public void SetCurrentLang(enumLanguage lang)
        {
            this._currentLanguage = lang;
            NotifyObserver();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Observer Added");
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Observer Deleted");
        }
    }
}
