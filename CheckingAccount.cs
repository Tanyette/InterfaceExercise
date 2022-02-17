using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class CheckingAccount : IBankAccount
    {
        public CheckingAccount()
        {

        }

        public int ChecksOrdered { get; set; }
        public bool DebitCardIssued { get; set; }
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public int SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public void CreateNewAccount() 
        { 
            throw new NotImplementedException();
        }

        public void Deposit()
        {
            Console.WriteLine("Deposit amount?");
            //accept user deposit
            
            //state deposit accepted
            //display current balance
        }

        public void Withdrawal()
        {
            throw new NotImplementedException();
        }
    }
}
