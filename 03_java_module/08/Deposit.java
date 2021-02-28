package com.epam.test.automation.java.practice8;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
public abstract class Deposit implements Comparable <Deposit>
{
    protected BigDecimal amount;
    protected int period;

    public int CompareTo(Deposit other)
    {
        //return amount.compareTo(other.amount);
        //return (this.amount.add(income()).subtract(other.amount).subtract(other.income()));
        BigDecimal currentTotalSum = amount.add(income());
        BigDecimal otherTotalSum = other.amount.add(other.income());
        return currentTotalSum.compareTo(otherTotalSum);
    }

    protected Deposit(BigDecimal depositAmount, int depositPeriod)
    {
        amount = depositAmount;
        period = depositPeriod;
    }

    public abstract BigDecimal income();

}
