using System;

namespace InheritanceTask
{
    //TODO: Create public class 'Employee' here
    class Employee
    {
        //TODO: Define three private fields: 'name'(string), 'salary'(decimal), 'bonus'(decimal)
        protected string name;
        protected decimal salary;
        protected decimal bonus;


        //TODO: Define public property 'Name' for getting 'name'
        public string Name
        {
            get
            {
                return name;
            }
        }

        //TODO: Define public property 'Salary' for getting and setting 'salary'
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }

        }
        

        //TODO: Define constructor with two parameters: 'name'(string), 'salary'(decimal). Assign parameters to its fields
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        //TODO: Define public virtual method 'SetBonus', that set value in 'bonus'
        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        //TODO: Define public method 'ToPay', that returns sum of salary and bonus
        public decimal ToPay()
        {
            decimal sum = salary + bonus;
            return sum;
        }
    }



    

    
    
}

