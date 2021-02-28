using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    class Company
    {
        //  Closed field employees (staff) – an array of Employee type
        private readonly Employee[] employees;

        //Constructor that receives employee array of Employee type with arbitrary length
        public Company(int n)
        {
            employees = new Employee[n];
        }


        public Company (params Employee[] employees)
        {
            this.employees = employees;
        }

        //Method GiveEverybodyBonus with money parameter companyBonus
        // that sets the amount of basic bonus for each employee.
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].SetBonus(companyBonus);
            }
        }

        //Method TotalToPay that returns total amount of salary of all employees
        // including awarded bonus
        public decimal TotalToPay()
        {
            decimal sum = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                sum += employees[i].ToPay();
            }
            return sum;
        }


        // Method NameMaxSalary that returns employee last name, who
        // received maximum salary including bonus.
        public string NameMaxSalary()
        {
            decimal maxSalary = 0;
            string employeeWithMaxSalaryName = "";
            for (int i = 0; i < employees.Length; i++)
            {
                if (maxSalary <= employees[i].ToPay())
                {
                    maxSalary = employees[i].ToPay();
                    employeeWithMaxSalaryName = employees[i].Name;
                }
            }
            return employeeWithMaxSalaryName;
        }
    }
    
}
