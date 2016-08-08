using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //---Calling Classes 
            Client CustomerName = new Client();//Client info
            Account CustomerAccount = new Account();
            CheckingAccount Checking = new CheckingAccount();
            Reserve ReserveAccount = new Reserve();
            Savings SavingsAccount = new Savings();


            Console.WriteLine("********** Bank Account **********");
            List<string> menu = new List<string>();
            menu.Add("\n1. View Client Information");
            menu.Add("2. View Account Balance");
            menu.Add("3. Checking Account Balance");
            menu.Add("4. Reserve Account Balance");
            menu.Add("5. Savings Account Balance");
            menu.Add("6. Deposit Funds");
            menu.Add("7. Witdraw Funds");
            menu.Add("8. Exit ");
           
            bool looptyLoop = true;

            while (looptyLoop)
            {
                mainMenu(menu);
                Console.Write("Please type number from the option above: ");
                int numberSelection = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (numberSelection)
                {
                    case 1:// View Client info
                        Console.WriteLine();
                        break;
                    case 2:// Account Balance
                        Console.WriteLine();
                        break;
                    case 3: //Checking
                        Console.Write("Enter withdraw amount: -$ ");
                        //decimal userinputWithdrawAmount = decimal.Parse(Console.ReadLine());
                        
                        break;
                    case 4: //Reserve
                        Console.WriteLine();
                        break;
                    case 5://Savings
                        Console.WriteLine();
                        break;
                    case 6: //Deposit
                        Console.WriteLine();
                        Console.WriteLine("Deposit ");
                        decimal userinputDepositAmount = decimal.Parse(Console.ReadLine());
                        break;
                    case 7: //Withdraw
                        Console.WriteLine("--------------------");
                        Console.Write("Enter withdraw amount: -$ ");
                        decimal userinputWithdrawAmount = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Deposit ");
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine("Exit");
                        Console.ReadKey();
                        looptyLoop = false;
                        break;
                }

            }




        }

        static void mainMenu(List<string> menu)
        {
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
