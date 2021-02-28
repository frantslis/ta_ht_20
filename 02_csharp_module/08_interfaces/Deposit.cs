using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{   
    public abstract class Deposit : IComparable<Deposit>

    {
        public decimal amount;
        public int period;

        public decimal Amount { get; }      

        public int Period { get; }

        public Deposit(decimal depositAmount, int depositPeriod)
        {
            Amount = depositAmount;
            Period = depositPeriod;
        }

        public abstract decimal Income();

        public int CompareTo(Deposit other)
        {
            return Amount.CompareTo(other.Amount);
            
        }

        /*
        
        public override bool Equals(object obj)
        {
            Deposit deposits = obj as  Deposit;
            return Amount.Equals(deposits.Amount);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        public static bool operator > (Deposit operand1, Deposit operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }
        
        public static bool operator < (Deposit operand1, Deposit operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }
        
        public static bool operator >=(Deposit operand1, Deposit operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }
        
        public static bool operator <=(Deposit operand1, Deposit operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
        public static bool operator !=(Deposit operand1, Deposit operand2)
        {
            return operand1.Equals(operand2);
        }
        public static bool operator ==(Deposit operand1, Deposit operand2)
        {
            return !operand1.Equals(operand2);
        }
        */

    }
}
