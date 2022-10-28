using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class arraylist
    {
        public static void demo1()
        {

            // adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };
            Console.WriteLine("ArrayList 1 Elements");
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("ArrayList 2 Elements");
            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);
            Console.WriteLine("-------------------------------------");
        }


        public static void demo2()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };
            int[]
        arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 
            Console.WriteLine("demo 2 class (DEMONSTRATION OF USING QUEUE METHOD TO ADD ELEMENTS IN AN ARRAY ");


            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < arlist1.Count; i++)

                Console.WriteLine(arlist1[i]);
            Console.WriteLine("-------------------------------------");
        }

        public static void demo3()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };
            Console.WriteLine("demo 3 class(DEMONSTRATION OF GETTING ELEMENTS FROM ARRAY USING THE INDEX OF IT ");
            Console.WriteLine("--------------------------------------------------------------------------------");

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            string secondElement = (string)arlist[1]; //returns "Bill"
                                                      //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var first = arlist[0]; //returns 1
            var second = arlist[1]; //returns "Bill"
            Console.WriteLine(second);                       //var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            Console.WriteLine("after updating elements in the list");
            arlist[0] = "Steve";
            arlist[1] = 100;
            for (int i = 0; i < arlist.Count; i++)
                Console.WriteLine(arlist[i]);
            Console.WriteLine("-------------------------------------");

        }

        public static void demo4()
        {
            Console.WriteLine("demo 4 class(DEMONSTRATION OF USING FOR AND FOR EACH IN AN ARRAY");
            Console.WriteLine("------------------------------------------------------------------");
            ArrayList arlist = new ArrayList()
                        {
                            1,
                            "Bill",
                            300,
                            4.5F
                        };

            Console.WriteLine("foreach loop");
            foreach (var item in arlist)
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 

            Console.WriteLine("");
            Console.WriteLine("for loop");

            for (int i = 0; i < arlist.Count; i++)
                Console.Write(arlist[i] + ",\n");
            Console.WriteLine("--------------------------------------------------------------");
        }
        public static void demo5()
        {

            Console.WriteLine("demo 5 class (DEMONSTRATION OF INSERTING ELEMENTS IN AN ARRAY ");
            Console.WriteLine("---------------------------------------------------------------");
            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist.Insert(1, "Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);
            Console.WriteLine("----------------------------------------------------------------------");
        }
        public static void demo6()
        {
            Console.WriteLine("demo 6 class (DEMONSTRATION OF REMOVE ELEMENT FROM ARRAY) ");
            Console.WriteLine("-----------------------------------------------------------");
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300
                };

            arList.Remove(null); //Removes first occurance of null
            arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            foreach (var item in arList)
                Console.WriteLine(item);
            Console.WriteLine("----------------------------------------------------------------------");
        }
        public static void demo7()
        {
            Console.WriteLine("demo 7 class (DEMONSTRATION OF CHECKING  ELEMENT PRESESNT IN AN ARRAY) ");
            Console.WriteLine("----------------------------------------------------------------------");
            ArrayList arList = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList.Contains(300)); // true
            Console.WriteLine(arList.Contains("Bill")); // true
            Console.WriteLine(arList.Contains(10)); // false
            Console.WriteLine(arList.Contains("Steve")); // false

            Console.WriteLine("----------------------------------------------------------------------");



        }
       
    }
}