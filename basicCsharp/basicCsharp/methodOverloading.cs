using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class methodOverloading
    {

        public int add(int n1, int n2)
        {


            return n1 + n2;
        }
        public double add(double n1, double n2)
        {
            return n1 + n2;


        }
        public int add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        } 
    }
    internal class methodOverload
    {
        public static void testOverLoad()
        {
          /*  methodOverloading new1 = new methodOverload();
            Console.WriteLine(new1.add(10, 20));
            Console.WriteLine(new1.add(100, 200, 300));
            Console.WriteLine(new1.add(10.1, 40.7));*/
        }
    }



    }



