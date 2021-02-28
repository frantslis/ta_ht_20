package com.epam.test.automation.java.practice8;

import java.math.BigDecimal;
import java.math.RoundingMode;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
class BaseDeposit extends Deposit {
    public BaseDeposit(BigDecimal amount, int period) {
        super(amount, period);
        this.amount = amount;
        this.period = period;
    }

    @Override
    public BigDecimal income() {
        BigDecimal result = amount.multiply(BigDecimal.valueOf(Math.pow(1.05, period))).subtract(amount);
        return result.setScale(2, RoundingMode.HALF_UP);
    }

    @Override
    public int compareTo(Deposit o) {
        return 0;
    }
}

