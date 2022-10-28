using assignment2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static assignment2.account;

namespace assignment2
{
    public class account
    {
        public String accnum;
        public String name;
        public String email;
        public double mobile;
        public double balance1;
        //public float balance;
        double dep, tobal, withdraw;
        bal bl1 = new bal();

       public String info()
        {
            Console.WriteLine("THE DETAILS OF YOUR ACCOUNT IS");
            Console.WriteLine("-----------------------------------------");
           //Console.WriteLine("NAME" + name);
            //Console.WriteLine("ACCOUNT NUMBER" + accnum);

            //Console.WriteLine("NAME" + name);
            return $"ACCOUNT NUMBER : {this.accnum} \nNAME : {this.name} \nEMAIL: {this.email} \nMOBILE: {this.mobile} \nBALANCE : {tobal}";

        }
       
        public void depo()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            accnum = Console.ReadLine();
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            balance1 = balance1 + dep;
            Console.WriteLine("total balance is " +balance1);
        }
        public void wid()
        {
            Console.WriteLine("Enter Account Number  :");
            accnum = Console.ReadLine();
            Console.WriteLine("Enter Withdraw Amount :");
            //withdraw = Convert.ToDouble(Console.ReadLine());
            withdraw = (double.Parse(Console.ReadLine()));
            if (withdraw <= tobal)
            {
                tobal = tobal - withdraw;
               // Console.WriteLine("------------------------------\n");

                //Console.WriteLine("Account Number: " + accnum);

                Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }
        

        public class bal : account
        {
            
                public double balance { get; set; }
        }
        }
    }

       


