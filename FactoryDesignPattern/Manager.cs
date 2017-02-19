using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class Manager : Employee
    {
        public Manager(double ExtraHoursCount)
        {
            this.ExtraHoursCount = ExtraHoursCount;
            this.ExtraHoursRate = 150;
            this.BasicSalary = 5200;
            this.Bonus = 400;
        }
    }
}
