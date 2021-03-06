namespace Aggregation
{    
    class SpecialDeposit : Deposit
    {
        
        public SpecialDeposit(decimal amount, int period) : base(amount, period)
        {
            this.amount = amount;
            this.period = period;
        }
       
        public override decimal Income()
        {           
            double amountDouble = System.Convert.ToDouble(amount);            
            double periodDouble = System.Convert.ToDouble(period);
            double balanceEnd = amountDouble;

            if (period == 0)
                return 0;
            else
            {
                for (double i = 1; i <= periodDouble; i++)
                {
                    balanceEnd = balanceEnd + balanceEnd * (i / 100);                    
                }

                decimal balanceEndDecimal = System.Convert.ToDecimal(balanceEnd);
                decimal difference = balanceEndDecimal - amount;

                return difference;
            }
        }
    }
}