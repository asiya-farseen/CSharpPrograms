using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class throw1
    {
        public static void throwdemonstration()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}