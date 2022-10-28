using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace Assignment

/*{
    internal class Account
    {
        public long accountNo;
        public string name;
        public string email;
        public long mobile;
        public double balance;



        public Account(long accountNo, string name, string email, long mobile)
        {
            this.accountNo = accountNo;
            this.name = name;
            this.email = email;
            this.mobile = mobile;



        }





        public string deposite(long accountNo)
        {
            if (this.accountNo == accountNo)
            {



                Console.WriteLine("Enter your Deposite Amount");
                double amttodeposit = Convert.ToDouble(Console.ReadLine());


                this.balance = this.balance + amttodeposit;
                Console.WriteLine("Amount Deposite Successfully");
            }
            return $"balance is: {this.balance}";
        }


        public string withdraw(long accountNo)
        {
            if (this.accountNo == accountNo)
            {
                Console.WriteLine("Enter your Withdraw Amount");
                double withdrawamt = Convert.ToDouble(Console.ReadLine());
                if (balance >= withdrawamt)
                {



                    this.balance = this.balance - withdrawamt;
                }


                else
                {
                    Console.WriteLine("Insufficient Fund");

                }
            }
            else
            {
                Console.WriteLine("Account Number Not Match");

            }
            return $"balance is: {this.balance}";

        }


        public string checkbalance(long accountNo)
        {
            if (this.accountNo == accountNo)
                return $"Balance is {this.balance}";
            else
                return "Account Number Not Match";

        }



    }


}*/
{
    internal class Account
    {
        int actno;
        string name;
string email;
long mobile;
float balance;

public Account()
{
Console.WriteLine("Default constructor");
}

public Account(int actno, string name, string email, long mobile)
{
this.actno = actno;
this.name = name;
this.email = email;
this.mobile = mobile;
this.balance = 0F;
}

public float deposit(int actno, float amtToDeposit)
{
this.actno = actno;
this.balance = this.balance + amtToDeposit;
return this.balance;
}

public float withdraw(int actno, float amtToWithdraw)
{
float bal = 0f;
try
{
this.actno = actno;

if (this.balance - amtToWithdraw > 0)
{
this.balance = this.balance - amtToWithdraw;
bal = this.balance;
}
else
{
bal = this.balance;
//  throw new InsufficientBalance();
throw new InsufficientBalance("Insufficient Balance");
}


}
catch (Exception oException)
{
Console.WriteLine("Exception " + oException);
}

return bal;
}

public double checkBalance(int actno)
{
this.actno = actno;
return this.balance;

}

}

internal class InsufficientBalance : Exception
{
    public InsufficientBalance()
    {
        Console.WriteLine("Insuffient Balance");
    }

    public InsufficientBalance(string msg) : base(msg) { }
}

internal class AccountDemo
{
    public static void testAccount()
    {
        Account act1 = new Account(1, "Raghu", "raghu@gmail.com", 9845547471L);

        float bal = act1.deposit(1, 10000F);
        Console.WriteLine("Bal after deposit of 10K " + bal);
        bal = act1.deposit(1, 20000F);
        Console.WriteLine("Bal after deposit of 20K " + bal);
        bal = act1.withdraw(1, 5000F);
        Console.WriteLine("Bal after withdrawal of 5K " + bal);
        bal = act1.withdraw(1, 35000F);
        Console.WriteLine("Bal after withdrawal of 35K " + bal);
    }

}
}