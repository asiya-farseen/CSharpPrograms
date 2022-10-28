using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    public static class loops
    {
        public static void whileLoop()
            {
            Console.WriteLine("while loop for table printing of 2");
            int start = 2;
            int end = 20;
            while(start <= end)
            {
            Console.WriteLine(start);
            start=start+2 ;

              }
             }
        public static void forLoop()
        {
            Console.WriteLine("FOR LOOP");
            int a = 5;
            int b = 50;
            for (int i = a; i <= 50; i += 5)
            {
                Console.WriteLine(i);
               
            }
        }
        public static void breakst()
        {
            Console.WriteLine("Break when it is 25");
            int c = 5;
            int d = 50;
            for (int i = c; i <= d; i += 5)
            {
                Console.WriteLine(i);
                if (i == 25)
                    break;
            }

        }
        public static void cnt()
        {
            Console.WriteLine("contunie if 20 thst skip 20 in 4 table");
            int e = 4;
            int f = 40;
            for (int j = e; j <= f; j+=4)
            {
                
                if (j == 20)
                    continue;
                Console.WriteLine(j);
            }
        }
    }
}
