package com.epam.test.automation.java.practice6;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class SalesPerson extends Employee {
    protected int percent;

    protected SalesPerson(String name, BigDecimal salary, int percent)
    {
        super(name, salary);
        this.name = name;
        this.salary = salary;
        this.percent = percent;
    }

    @Override
    public void setBonus(BigDecimal bonus) {
        if (bonus == null || (bonus.compareTo(new BigDecimal(0))) < 0)
            throw new IllegalArgumentException();
        else if (percent <= 100)
        {
            this.bonus = bonus;
        }
        else if (percent > 100 && percent <= 200)
        {
            this.bonus = bonus.add(bonus);
        }
        else if (percent > 200)
        {
            this.bonus = bonus.add(bonus.add(bonus));
        }
    }


}
