using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    //TODO: Create public class 'SalesPerson' here, which inherits from 'Employee' class
    class SalesPerson : Employee
    {
        //TODO: Define private integer field: 'percent'
        protected int percent;

        //TODO: Define constructor with three parameters: 'name'(string), 'salary'(decimal) and 'percent'(int). 
        // Assign two first parameters to base class.
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
            this.percent = percent;
        }
        //TODO: Override public virtual method 'SetBonus', which increases bonus depending on percent
        public override void SetBonus(decimal bonus)
        {
            if (percent <= 100)
            {
                this.bonus = bonus;
            }
            else if (percent > 100 && percent <= 200)
            {
                this.bonus = bonus + bonus;
            }
            else if (percent > 200)
            {
                this.bonus = 3 * bonus;
            }
        }
    }
}