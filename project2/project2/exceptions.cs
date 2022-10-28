using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static project2.exceptions;

namespace project2
{
    internal class exceptions
    {
        public class Student
        {

            public string StudentName { get; set; }
        }
        public static void demo1()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("EXCEPTION WHEN YOU ENTER A NON NUMERIC CHARACTER");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter a number: "); // enter non-numeric value to see the exception

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("Squre of {0} is {1}", num, num * num);
        }
        public static void demo2()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("EXCEPTION WHEN YOU ENTER A NON NUMERIC CHARACTER AND AGAIN GIVING A RETRY ");
            Console.WriteLine("---------------------------------------------------------------------------");
            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine("Squre of {0} is {1}", num, num * num);
            }
            catch
            {
                Console.WriteLine("Error occurred.");
                demo2();
            }
            finally
            {
                Console.WriteLine("Re-try with a different number.");
                
            }
        }

        public static void demo3()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("EXCEPTION WHEN YOU DIVIDE A NUMBER BY ZERO ");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Please enter a number to divide 100: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again.");
            }

        }
        public static void demo4()
        {

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("EXCEPTION WHEN U SET THE DIVEDER BY ZERO AND THEN TRY TO PRINT(INNER CACHE)  ");
            Console.WriteLine("-----------------------------------------------------------------------------");


            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }

            catch
            {
                Console.WriteLine("Outer catch");
            }
        }


        public static void demo5()
        {

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("EXCEPTION WHEN U SET THE DIVEDER BY ZERO AND THEN TRY TO PRINT(OUTTER CACHE)  ");
            Console.WriteLine("-----------------------------------------------------------------------------");




            Student std = null;

            var divider = 0;

            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }

            catch
            {
                Console.WriteLine("Outer catch");
            }
        }

        public static void demo6()
        {

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("EXCEPTION FOR DEMONSTRATION OF NULL POINTER  ");
            Console.WriteLine("-----------------------------------------------------------------------------");


            Student std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null. ");

            Console.WriteLine(std.StudentName);
        }
    }

}



