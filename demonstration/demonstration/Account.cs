using System;
using System.Net.NetworkInformation;

namespace first
{
    class Account
    {
        public static void main()
        {
            int amount = 0, deposit, withdraw;
            int choice, acc_no, number;
            string name, email;

            Console.WriteLine("Enter your ACC_NUM:\n");
            acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name:\n");
            name = (Console.ReadLine());
            Console.WriteLine("Enter your Email:\n");
            email = (Console.ReadLine());

            while (true)
            {



                Console.WriteLine("WELCOME TO YES BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > amount)
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("THANK YOU…");
                        break;
                }



                Console.WriteLine("\n\n THANKS FOR USING YES ATM SERVICE");
            }
        }
    }
}
