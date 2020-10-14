using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCore.FactoryDesignPattern
{
    /// <summary>
    /// #Motivation
    /// Now i have a set of classes of similar types (in the sample i have an employee as parent class, Engineer and Manager as Childs) that share some 
    /// functions but each one of them handles them by its own way.
    /// Doing this by the old way requires me to make a separated object for each type of them and a switch statement to do
    /// the different job depending on the type.
    /// 
    /// #Structure
    /// Parent abstract class with infinite number of childs.
    /// 
    /// #Sample Problem
    /// I need to calculate the salary of the employees, each designation has its own different claculations, and i don't want to put a lot of 
    /// functions to Calculate salary in the main class.
    /// I will have to declare a lot of functions at the same class for each designation.
    /// 
    /// #Solution
    ///     1. Implement the parent class with all the shared parameters and methods and abstract function for the CalculateSalary.
    ///     2. Implement a new derived class for each designation.
    ///     3. Each derived class will have a different [OVERRIDEN] declaration CalculateSalary method.
    ///     4. You're Done !
    /// </summary>
    public class Engineer : Employee
    {
        public Engineer(double extraHoursCount)
        {
            this.ExtraHoursCount = extraHoursCount ;
            this.ExtraHoursRate = 100;
            this.BasicSalary = 4000;
            this.Bonus = 150;
        }

        public override double CalculateSalary()
        {
            return BasicSalary + ExtraHoursCount*ExtraHoursRate + Bonus + 500000;// Even the other one is manager, Engineers should be the best
        }
    }
}
