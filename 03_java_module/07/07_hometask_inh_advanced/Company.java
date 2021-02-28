package com.epam.test.automation.java.practice6;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class Company {

        private final Employee[] employees;


        public Company(int n)
        {
            employees = new Employee[n];
        }


        public Company (Employee[] employees)
        {
            this.employees = employees;
        }

        public void giveEverybodyBonus(BigDecimal companyBonus)
        {
            for (Employee employee : employees)
            {
                employee.setBonus(companyBonus);
            }
        }

        public BigDecimal totalToPay()
        {
            BigDecimal sum = BigDecimal.ZERO;
            for (Employee employee : employees)
            {
                sum = sum.add(employee.toPay());

            }
            return sum;
        }

        public String nameMaxSalary()
        {
            BigDecimal maxSalary = BigDecimal.ZERO;

            String employeeWithMaxSalaryName = "";
            for (Employee employee : employees)
            {
                if (employee.toPay().compareTo(maxSalary) == 1 || employee.toPay().compareTo(maxSalary) == 0)
                {
                    maxSalary = employee.toPay();
                    employeeWithMaxSalaryName = employee.name;
                }
            }
            return employeeWithMaxSalaryName;
        }
}
