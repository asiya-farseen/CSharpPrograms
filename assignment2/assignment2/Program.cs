using System;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using static assignment2.account;


namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bal bl1 = new bal();
            //account cust1 = new account();
            bl1.accnum = "05";
           bl1.name = "HARRY POTTER";
            bl1.email = "potterhead@harry.com";
            bl1.mobile = 9090909090;
            // Console.WriteLine(cust1.print());

            while (true)
            {
                Console.Write("1. DISPLAY THE DETAILS OF THE CUSTOMER \n2. Check balance\n3. Deposit\n4. Withdraw\nX. Terminate\n\nSelect Function: ");
                string selGo = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");
                if (selGo == "1")
                {
                    Console.WriteLine(bl1.info());
                }
                else if (selGo == "2")
                {
                    
                    Console.WriteLine(bl1.info());
                        }
                else if(selGo=="3")
                {
                    bl1.depo();
                   
                    }
                else if(selGo=="4")
                {
                    bl1.wid();
                }
            }
                }
                   }
                }
            
       
 