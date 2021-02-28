namespace Aggregation
{   
    class Client
    {       
        private readonly Deposit[] deposits;
        
        public Client()
        {
            deposits = new Deposit[10];
        }
       
        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }
        
        public decimal TotalIncome()
        {
            decimal sum = 0;

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null)
                    sum += deposits[i].Income();
            }
            return sum;
        }
        
        public decimal MaxIncome()
        {
            decimal maxIncomeDeposit = deposits[0].Income();

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != null && maxIncomeDeposit < deposits[i].Income())
                {
                    maxIncomeDeposit = deposits[i].Income();
                }
            }
            return maxIncomeDeposit;
        }
        
        public decimal GetIncomeByNumber(int number)
        {
            int j = number - 1;
            decimal numberIncomeDeposit = 0;

            for (int i = 1; i <= deposits.Length; i++)
            {
                if (deposits[j] != null && i == number)
                {
                    numberIncomeDeposit = deposits[j].Income();
                }
            }
            return numberIncomeDeposit;
        }
    }
}