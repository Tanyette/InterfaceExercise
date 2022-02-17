using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IBankAccount
    {
        public int ChecksOrdered { get; set; }

        public bool DebitCardIssued { get; set; }
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public void Deposit(); //stubbed out method

        public void Withdrawal();
    }
}
