package com.epam.test.automation.java.practice7;

import java.math.BigDecimal;

/**
 * <summary>
 * Implement class according to description of task.
 * </summary>
 */
class Client
{
    private final Deposit[] deposits;

    public Client()
    {
        deposits = new Deposit[10];
    }

    public boolean addDeposit(Deposit deposit)
    {
        for (int i = 0; i < deposits.length; i++)
        {
            if (deposits[i] == null)
            {
                deposits[i] = deposit;
                return true;
            }
        }
        return false;
    }

    public BigDecimal totalIncome()
    {
        BigDecimal sum = BigDecimal.ZERO;

        for (int i = 0; i < deposits.length; i++)
        {
            if (deposits[i] != null)
                sum = sum.add(deposits[i].income());
        }
        return sum;
    }

    public BigDecimal maxIncome()
    {
        BigDecimal maxIncomeDeposit = deposits[0].income();

        for (int i = 0; i < deposits.length; i++)
        {
            if (deposits[i] != null && maxIncomeDeposit.compareTo(deposits[i].income()) == -1)
            {
                maxIncomeDeposit = deposits[i].income();
            }
        }
        return maxIncomeDeposit;
    }

    public BigDecimal getIncomeByNumber(int number)
    {
        int j = number;
        BigDecimal numberIncomeDeposit = BigDecimal.ZERO;

        for (int i = 1; i <= deposits.length; i++)
        {
            if (deposits[j] != null && i == number)
            {
                numberIncomeDeposit = deposits[j].income();
            }
        }
        return numberIncomeDeposit;
    }
}
