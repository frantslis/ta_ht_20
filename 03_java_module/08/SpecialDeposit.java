package com.epam.test.automation.java.practice8;


import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
class SpecialDeposit extends Deposit implements Prolongable
{

    public SpecialDeposit(BigDecimal amount, int period)
    {
        super(amount, period);
        this.amount = amount;
        this.period = period;
    }

    public boolean canToProlong()
    {
        return amount.compareTo(BigDecimal.valueOf(1000)) == 1;
    }

    @Override
    public  BigDecimal income()
    {
        BigDecimal summa = amount;
        for (int i = 1; i <= period; i++) {
            summa = summa.add(summa.multiply(BigDecimal.valueOf(i).multiply(BigDecimal.valueOf(0.01))));
        }

        return summa.subtract(amount);
    }

    @Override
    public int compareTo(Deposit o) {
        return 0;
    }
}
