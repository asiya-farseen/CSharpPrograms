using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public static class demo
    {
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) simpleinterest");
            Console.WriteLine("2) table");
            Console.WriteLine("3) milestokillmt");
            Console.WriteLine("4) dollars");
            Console.WriteLine("5) euro");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    simpleinterest();
                    return true;
                case "2":
                    table();
                    return true;
                case "3":
                    milestokillm();
                    return true;
                case "4":
                    dollars();
                    return true;
                case "5":
                    euro();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        public static void simpleinterest()
        {
            double pi, ri, si;
            int t;
            Console.Write("PROGRAM TO CALCLUATE SIMPLE INTERSEST: ");
            Console.Write("enter the principal ammount");
            pi = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the rate of interest");
            ri = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the time ");
            t = Convert.ToInt32(Console.ReadLine());
            si = ((pi * ri * t) / 100);

            Console.WriteLine("the Simple interesrt for the given amount is {0}\n", si);
            Console.ReadLine();

        }
        public static void table()
        {

            Console.Write("enter the number you want to display the table of  :  ");
            var z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", z, j, z * j);
                Console.WriteLine("------------");
            }


        }
        public static void milestokillm()
        {
            double a, b;
            Console.WriteLine("enter the miles you want to convert it into killometers");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * 1.6;
            Console.WriteLine("the kilometer of {0}\n", a);
            Console.WriteLine("is{0} \n", b);
        }
        public static void dollars()
        {
            double c, d;
            Console.WriteLine("ENTER THE AMOUNT IN INDIAN RUPEES");
            c = Convert.ToDouble(Console.ReadLine());
            d = c * 61.06;
            Console.WriteLine("the amount in Dollars of INR {0}", c);
            Console.WriteLine("is DOLAR{0}  ", d);
        }
        public static void euro()
        {
            double e, f;
            Console.WriteLine("ENTER THE AMOUNT IN INDIAN RUPEES");
            e = Convert.ToDouble(Console.ReadLine());
            f = e * 0.01264;
            Console.WriteLine("the amount in Dollars of INR {0}", e);
            Console.WriteLine("is EURO{0}  \n", f);
        }


       
    }
    
}
