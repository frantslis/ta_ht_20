package com.epam.test.automation.java.practice6;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement code according to description of task.
 * </summary>
 */
public class Manager extends Employee {
    protected int quantity;

    protected Manager(String name, BigDecimal salary, int clientAmount) {
        super(name, salary);
        this.name = name;
        this.salary = salary;
        quantity = clientAmount;
    }


    @Override
    public void setBonus(BigDecimal bonus) {
        if (bonus == null || (bonus.compareTo(new BigDecimal(0))) < 0)
            throw new IllegalArgumentException();
        else if (quantity <= 100) {
            this.bonus = bonus;
        } else if (quantity > 100 && quantity <= 150) {
            BigDecimal addBonus1 = BigDecimal.valueOf(500);
            this.bonus = bonus.add(addBonus1);
        } else if (quantity > 150) {
            BigDecimal addBonus2 = BigDecimal.valueOf(1000);
            this.bonus = bonus.add(addBonus2);
        }
    }


}
