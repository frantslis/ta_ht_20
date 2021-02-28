package com.epam.test.automation.java.practice7;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
public abstract class Deposit
{
    protected BigDecimal amount;
    protected int period;

    protected Deposit(BigDecimal depositAmount, int depositPeriod)
    {
        amount = depositAmount;
        period = depositPeriod;
    }

    public abstract BigDecimal income();

}
