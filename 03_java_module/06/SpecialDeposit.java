package com.epam.test.automation.java.practice7;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
class SpecialDeposit extends Deposit
        {

        public SpecialDeposit(BigDecimal amount, int period)
        {
            super(amount, period);
        this.amount = amount;
        this.period = period;
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
        }

