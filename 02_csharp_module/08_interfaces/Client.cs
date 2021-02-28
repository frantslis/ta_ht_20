using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{  
    class Client : IEnumerable<Deposit>
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }
        
        public IEnumerator<Deposit> GetEnumerator()
        {
            foreach (Deposit name in deposits)
                yield return name;
        }
        
        
        IEnumerator<Deposit> IEnumerable<Deposit>.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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

        public int CountPossibleToProlongDeposit()
        {
            int counter;
            counter = 0;

            for (int i = 0; i < deposits.Length; i++)
            {

                if (deposits[i] is SpecialDeposit)
                {
                    SpecialDeposit sd = deposits[i] as SpecialDeposit;

                    if (sd.CanToProlong())
                    {
                        counter += 1;
                    }
                }
                else if (deposits[i] is LongDeposit)
                {
                    LongDeposit ld = deposits[i] as LongDeposit;
                    if (ld.CanToProlong())
                    {
                        counter += 1;
                    }
                }
            }

            return counter;
        }

        public void SortDeposits()
        {

            Array.Sort(deposits);
            Array.Reverse(deposits);
   
        }

        
    }

    
}
