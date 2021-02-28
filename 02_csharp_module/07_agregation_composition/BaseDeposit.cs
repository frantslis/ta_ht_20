namespace Aggregation
{   
    class BaseDeposit : Deposit
    {        
        public BaseDeposit(decimal amount, int period) : base(amount, period)
        {
            this.amount = amount;
            this.period = period;            
        }
        
        public override decimal Income()
        {
            double interest = 0.05;
            double balanceEnd = 0;
            
            double amountDouble = System.Convert.ToDouble(amount);

            if (period == 0)
                return period;
            else
            {
                for (double i = 1; i <= period; i++)
                {
                    balanceEnd = amountDouble * System.Math.Pow(1 + interest, i);                    
                }
               
                decimal balanceEndDecimal = System.Convert.ToDecimal(balanceEnd);
                decimal difference = balanceEndDecimal - amount;

                decimal result = System.Math.Round(difference, 2, System.MidpointRounding.ToEven);

                return result;
            }
        }
    }



}