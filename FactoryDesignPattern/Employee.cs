using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace DesignPatterns.FactoryDesignPattern
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
    public abstract class Employee
    {
        public double BasicSalary { get; set; }

        public double Bonus { get; set; }

        public double ExtraHoursRate { set; get; }

        public double ExtraHoursCount { set; get; }
        
        public abstract double CalculateSalary();

        public override string ToString()
        {
            return "Basic Salary:" + BasicSalary + Environment.NewLine
                + "Bonus:" + Bonus + Environment.NewLine
                + "Extra Hours Rate:" + ExtraHoursRate + Environment.NewLine
                + "Extra Hours Count:" + ExtraHoursCount + Environment.NewLine
                + "Total Salary:" + CalculateSalary();
        }
    }
}
