using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverDesignPattern
{
    class LanguageObserver : IObserver
    {
        private ISubject _languageTracker;
        private enumLanguage _language;
        private static int ObserversCount = 0;
        private int ObserverId = 0;

        public LanguageObserver(ISubject languageTracker)
        {
            ObserversCount++;
            this.ObserverId = ObserversCount;
            this._languageTracker = languageTracker;
            this._languageTracker.RegisterObserver(this);
            Console.WriteLine("New Observer Created ..");
        }

        public void Update(enumLanguage language)
        {
            this._language = language;
            Console.WriteLine(this.ObserverId + " : " + language.ToString());
        }
    }
}
