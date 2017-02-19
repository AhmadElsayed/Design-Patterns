using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class Engineer : Employee
    {
        public Engineer(double ExtraHoursCount)
        {
            this.ExtraHoursCount = ExtraHoursCount;
            this.ExtraHoursRate = 100;
            this.BasicSalary = 4000;
            this.Bonus = 150;
        }
    }
}
