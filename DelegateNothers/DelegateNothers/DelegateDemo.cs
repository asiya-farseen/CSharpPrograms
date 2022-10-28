using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNothers
{
    public delegate int caluclate(int n1, int n2);

    internal class calculator
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Mul(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }

    
}
    internal class DelegateDemo
    {
        public static void DemoDelegate()
        {

           

           
            int result = 0;
            result = calculator.Add(10, 20);
            Console.WriteLine("addtion of 2 numbers using regular method : " + result);
            caluclate calc = new caluclate(calculator.Add);
           
            calc = calculator.Sub;
            result = calc.Invoke(10, 20);
            Console.WriteLine("Subtration of 2 numbers : using delegate " + result);
            calc = calculator.Div;
            result = calc.Invoke(100, 20);
            Console.WriteLine("Division of 2 numbers : using delegate " + result);
            calculator mul = new calculator();
            /*  calc = new caluclate(mul.Mul);    // create instance of Program
              result = calc.Invoke(10, 20);
              Console.WriteLine("multiplication  of 2 numbers : using delegate " + result);*/


            calc = calculator.Mul;
            result = calc.Invoke(10, 20);
            Console.WriteLine("mutipication of 2 numbers : using delegate " + result);
            Console.WriteLine("Multicast delegate");
            caluclate calc1 = new caluclate(calculator.Add);
            calc1 += calculator.Sub;
            calc1 += calculator.Mul;
            int result1 = calc1(100, 200);
            Console.WriteLine("Multicastdelgate : " + result1);
         



        }
    }
}
