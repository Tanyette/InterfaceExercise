using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IPersonalInfo
    {
        public int SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }


        public DateTime DateOfBirth { get; set; }

        public IBankAccount CreateNewAccount(string firstName, string lastName); 
         

        
    }
}
