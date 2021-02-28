package com.epam.test.automation.java.practice8;


import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
class LongDeposit extends Deposit implements Prolongable
{
    public LongDeposit(BigDecimal amount, int period)
    {
        super(amount, period);
        this.amount = amount;
        this.period = period;

    }

    public int CompareTo(Deposit other)
    {
        return amount.compareTo(other.amount);

    }

    public boolean canToProlong()
    {
        return period <= 36;
    }

    @Override
    public  BigDecimal income()
    {
        double interest = 0.15;
        BigDecimal balanceEnd = BigDecimal.ZERO;
        BigDecimal amountD = amount;

        if (period <= 6)
            return BigDecimal.ZERO;
        else
        {
            for (double i = 6; i <= period; i++)
            {
                balanceEnd = amountD.add(BigDecimal.valueOf(Math.pow(1 + interest, i - 6)));
            }

            return balanceEnd.subtract(amount);
        }
    }

    @Override
    public int compareTo(Deposit o) {
        return 0;
    }
}
