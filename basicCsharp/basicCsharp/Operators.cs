using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    public static class Operators
    {
        public static void ap()
        {
            Console.WriteLine("ARITHEMETIC OPERATOR");
            int n1 = 100;
            int n2 = 33;
            int result = n1 + n2;
            Console.WriteLine(result);
            result = n1 % n2;
            Console.WriteLine(result);
            result = n1 - n2;
            Console.WriteLine(result);
            result = 100;
            result -= 20;
            Console.WriteLine(result);
            result = 100;
            result += 20;
            Console.WriteLine(result);
            result = 100;
            result /= 5;
            Console.WriteLine(result);
        }
        public static void logicalOpeartor()
        {
            int a = 100;
            int b = 200;
            bool re = a >= b;
            Console.WriteLine(re);
            re = b < 5 || b < 4;
            Console.WriteLine(re);
        } 
    }

        public class Test
        {
            public static void greet()
        {
            Console.WriteLine("Hello World");
        }
        public void info()

        {
            Console.WriteLine("info");
        }
}

        }
    

