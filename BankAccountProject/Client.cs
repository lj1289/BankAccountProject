using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {   
        //Field
        private string firstName;
        private string lastName;
        private string accountNumber;
        
        // Properties 
        public string Firstname
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string Lastname
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Accountnumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        //Constructors
        //Methods



    }
}
