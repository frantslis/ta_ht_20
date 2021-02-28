using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask

{
    //TODO: Create public class 'Manager' here, which inherits from 'Employee' class
    class Manager : Employee  
    {
        //TODO: Define private integer field: 'quantity'
        protected int quantity;

        //TODO: Define constructor with three parameters: 'name'(string), 'salary'(decimal) and 'clientAmount'(int). Assign two first parameters to base class.
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            this.name = name;
            this.salary = salary;
            quantity = clientAmount;
        }

        //TODO: Override public virtual method 'SetBonus', which increases bonus depending on clients amount
        public override void SetBonus(decimal bonus)
        {
            if (quantity <= 100)
            {
                this.bonus = bonus;
            }
            else if (quantity > 100 && quantity <= 150)
            {
                this.bonus = bonus + 500;
            }
            else if (quantity > 150)
            {
                this.bonus = bonus + 1000;
            }
        }
    }
   
}

