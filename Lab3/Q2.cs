//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3
//{
//    class BankAccount
//    {
//        public int AccountNumber { get; set; }
//        public int Balance { get; set; }

//        public void Deposit(int amount)
//        {
//            Balance += amount;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount();
//            account.AccountNumber = 522;
//            account.Balance = 1000;

//            Console.WriteLine("Enter the amount: ");
//            int amount = Convert.ToInt32(Console.ReadLine());
//            account.Deposit(amount);

//            Console.WriteLine("Balance: " + account.Balance);
//            Console.ReadLine();
//        }
//    }
//}
