using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static double userBalance = 10000;

        static void Checkbalance()
        {
            Console.WriteLine("Your current balance is: "+userBalance);
        }

        static void Deposit()
        {
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            userBalance += amount;
            Console.WriteLine("Successful ! Your balance is: "+userBalance);
        }

        static void Withdraw()
        {
            Console.WriteLine("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > userBalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                userBalance -= amount;
                Console.WriteLine("Successful ! Your balance is: "+userBalance);
            }
        }
        static void Main(string[] args)
        {
            bool programRunning = true;

            while (programRunning)
            {
                Console.WriteLine("Welcome ! Enter choice number");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Checkbalance();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        Withdraw();
                        break;
                    case 4:
                        Console.WriteLine("Thank you");
                        programRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
