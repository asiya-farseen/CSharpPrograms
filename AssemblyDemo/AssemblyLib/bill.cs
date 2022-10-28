/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLib
{
    public static class bill
    {

        public static void demo()
        {


            int custid, unit;
            double amt, total;
            string name;

            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            name = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            unit = Convert.ToInt32(Console.ReadLine());
            if (unit <= 100)

                amt = unit * 1;
            else if (unit > 100 && unit <= 200)

                amt = (100 * 1) + (unit - 100) * 2;
            else if (unit >= 200 && unit < 300)

                amt = (100 * 1) + (100 * 2) + (unit - 200) * 3;
            else
                amt = (100 * 1) + (100 * 2) + (100 * 3) + (unit - 300) * 5;

            total = amt;

            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       :{0}\n", custid);
            Console.Write("Customer Name                       :{0}\n", name);
            Console.Write("unit Consumed                       :{0}\n", unit);
            Console.WriteLine("---------------------------------------------");
            Console.Write("Amount Charges                      :{0}\n", total);
        }


      
        }
    }

*/

