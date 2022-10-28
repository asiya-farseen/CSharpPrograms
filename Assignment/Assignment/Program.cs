using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static Assignment.Account;
using static Assignment.Account;
namespace Assignment
{
    class Program
    {
        static void Main(String[] args)
        {
            AccountDemo.testAccount();
        }
    }
}

        /*    // Account acc1 = new Account(accountNo, name, email, phone);


            Console.WriteLine("Enter your Account Number");
            long accountNo = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your E-Mail");
            string email = Console.ReadLine();


            Console.WriteLine("Enter your Mobile Number");
            long phone = (long)Convert.ToInt64(Console.ReadLine());





            Account acc1 = new Account(accountNo, name, email, phone);


            // Console.WriteLine("Balance is "+ acc1.checkbalance(12345678910));
            String retry = "n";
            do { 
            Console.WriteLine("Enter your Operation");


            Console.WriteLine("\n1.Balance Check\n2.Amount Withdraw\n3.Amount Deposit");
            //Console.WriteLine("do you want to cntt");
            
             
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:


                        Console.WriteLine(acc1.checkbalance(accountNo));
                        break;
                    case 2:
                        Console.WriteLine(acc1.withdraw(accountNo));
                        break;
                    case 3:
                        Console.WriteLine(acc1.deposite(accountNo));
                        break;
                  
                    default:
                        
                        Console.WriteLine("Would you like to retry?");
                        retry = Console.ReadLine();
                        break;
                       
                }
            }
            while (retry != "n");
            }

            }
    }





         /*       static void dataTypes()
                {
                    int n1 = 10;
                    long l1 = 10l;
                    float f1 = 100.0f;
                    double d1 = 1000.00001d;
                    bool isActive = true;
                    char c = 'A';
                    String s1 = "C# programing";


                    Console.WriteLine(" int n1" + n1);
                    Console.Write($" f1 is {f1} and d1 is {d1}");

                }*/



/* static void implicitTypeConversion()
  {
      int n1 = 10;
      double d1 = n1;
      Console.WriteLine($" int n1 {n1} : double d1 {d1}");
      float f1 = 1000.0001f;
      double d2 = f1;
      Console.WriteLine($" float f1 {f1} and double d1 {d2}");
  }


  static void explicitTypeConversion()
  {
      double d1 = 10.0001d;
      int n1 = (int)d1;
      Console.WriteLine($" double d1 {d1} : int n1 {n1}");
      double d2 = 1000.0001d;
      float f1 = (float)d2;
      Console.WriteLine($" double d1 {d2} and float f1 {f1}");
  }
}*/
