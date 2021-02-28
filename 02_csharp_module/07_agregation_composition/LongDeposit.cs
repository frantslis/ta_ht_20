namespace Aggregation
{    
    class LongDeposit : Deposit
    {    
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {
            this.amount = amount;
            this.period = period;

        }
         
        public override decimal Income()
        {           
            double interest = 0.15;
            double balanceEnd = 0;
            double amountD = System.Convert.ToDouble(amount);

            if (period <= 6)
                return 0;
            else
            {
                for (double i = 6; i <= period; i++)
                {

                    balanceEnd = amountD * System.Math.Pow(1 + interest, i - 6);
                }

                decimal balanceEndD = System.Convert.ToDecimal(balanceEnd);
                decimal difference = balanceEndD - amount;
                return difference;               
            }
        }
    }
}