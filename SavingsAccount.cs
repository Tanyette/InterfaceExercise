using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SavingsAccount : IBankAccount,IPersonalInfo
    {
        public int ChecksOrdered { get; set; }
        public bool DebitCardIssued { get; set; }
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public double InterestRate { get; set; }

        public int SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IBankAccount CreateNewAccount(string firstName, string lastName) 
        { 
            IBankAccount myAccount = new CheckingAccount() { FirstName = firstName,LastName = lastName};

            return myAccount;
        }

        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void Withdrawal()
        {
            throw new NotImplementedException();
        }
    }
}
