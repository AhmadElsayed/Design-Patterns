using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace DesignPatterns.FactoryDesignPattern
{
    public abstract class Employee
    {
        public double BasicSalary { get; set; }

        public double Bonus { get; set; }

        public double ExtraHoursRate { set; get; }

        public double ExtraHoursCount { set; get; }

        public double GetTotalSalary()
        {
            return BasicSalary + Bonus + ExtraHoursCount * ExtraHoursRate;
        }
    }
}
