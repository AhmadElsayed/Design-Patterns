using System;
using System.Linq;
using DesignPatterns.ObserverDesignPattern;
using DesignPatterns.StrategyDesignPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStrategyDesignPattern();
            //TestObserverDesignPattern();
            //Console.WriteLine(solution("(())))("));
            Console.WriteLine(string.Join("", solution(new int[]{1, 0, 0, 1, 1}) ));
            Console.ReadLine();
        }
        //public static int solution(int X, int Y, int D)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    return Convert.ToInt32(Math.Ceiling( (Y - X) / Convert.ToDecimal(D)));
        //}
        //public static int solution(int[] A)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    int RightSide = 0, LeftSide = 0;
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            LeftSide = 0;
        //            RightSide = A.Sum() - A[0];
        //        }
        //        else
        //        {
        //            LeftSide += A[i - 1];
        //            RightSide -= A[i];
        //        }
        //        if (RightSide == LeftSide && i != 1 && i != 3)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //public static int solution(string S)
        //{

        //    for (int i = 0; i < S.Length - 1; i ++)
        //    {
        //        if (S.Substring(0, i).Count(x => x == '(') == S.Substring(i + 1, S.Length - (i + 1)).Count(x => x == ')'))
        //            return i + 1;
        //    }
        //    return -1;
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //}

        public static int[] solution(int[] A)
        {
            double num = 0;
            for (int i = 0; i < A.Length; i ++)
            {
                num += A[i]*Math.Pow(-2, i);
            }

            int result = Convert.ToInt32(String.Join("", A), 2) * -1;
            string strResult = Convert.ToString(result, 2);
            return strResult.Select(x => Convert.ToInt32(x)).ToArray();
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
        private static void TestObserverDesignPattern()
        {
            LanguageTracker tracker = new LanguageTracker();

            LanguageObserver observe = new LanguageObserver(tracker);

            tracker.SetCurrentLang(enumLanguage.English);
            tracker.SetCurrentLang(enumLanguage.French);
            tracker.SetCurrentLang(enumLanguage.German);


            LanguageObserver observe2 = new LanguageObserver(tracker);

            tracker.SetCurrentLang(enumLanguage.German);

            tracker.RemoveObserver(observe);

            tracker.SetCurrentLang(enumLanguage.French);
        }

        private static void TestStrategyDesignPattern()
        {
            Dog dog = new Dog();
            Bird bird = new Bird();

            Console.WriteLine("Dog: ");
            dog.TryToFly();
            Console.WriteLine("Bird: ");
            bird.TryToFly();
        }
    }
}
