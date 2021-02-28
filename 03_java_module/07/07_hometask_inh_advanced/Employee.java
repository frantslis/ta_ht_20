package com.epam.test.automation.java.practice6;


import java.math.BigDecimal;

/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public abstract class Employee {
    protected String name;
    protected BigDecimal salary;
    protected BigDecimal bonus;

    public String getName()
    {
        return name;
    }

    public void setSalary(BigDecimal salary) {
        this.salary = salary;
    }

    public BigDecimal getSalary() {
        return salary;
    }

    public BigDecimal getBonus() {
        return bonus;
    }

    public Employee(String name, BigDecimal salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public BigDecimal toPay()
    {
        return bonus.add(salary);
    }

    public abstract void setBonus(BigDecimal bonus);

}
