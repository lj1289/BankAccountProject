using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Account
    {
        //Fields
        //private decimal deposit;
        //private decimal withdraw;
        private decimal previousBalance;
        //private decimal currentBalance;
        private decimal amount;

        


        //Properties
        //public decimal Deposit
        //{
        //    get { return this.deposit; }
        //    set { this.deposit = value; }
        //}

        //public decimal Withdraw
        //{
        //    get { return this.withdraw; }
        //    set { this.withdraw = value; }
        //}

        public decimal Previousbalance
        {
            get { return this.previousBalance; }
            set { this.previousBalance = value; }
            
        }
        public decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }


        //Constructors
        public Account()
        {
            this.previousBalance = 100;
        }


        //Methods 
        public decimal Withdraw(decimal amount)
        {
            decimal currentBalance = this.Previousbalance - amount;
            Previousbalance = currentBalance;
            return currentBalance;
        }

        public decimal Deposit(decimal amount)
        {
            decimal currentBalance = this.Previousbalance + amount;
            Previousbalance = currentBalance;
            return currentBalance;
        }

        public void AccountBalances()
        {

        }
        
    }
}
