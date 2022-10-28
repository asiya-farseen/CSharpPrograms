using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class lists
    {
        public static void demo8()
        {
            Console.WriteLine("demo 8 class (DEMONSTRATION LISTS ");
            Console.WriteLine("--------------------------------------------------------");
            // adding elements using add() method
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("No of elelemts: " + primeNumbers.Count);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of elelemts: " + bigCities.Count);

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            Console.WriteLine("No of elelemts: " + students.Count);
        }


        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public static void demo9()
        {
            Console.WriteLine("demo 9 class (DEMONSTRATION OF ACCESSING LISTS ");
            Console.WriteLine("--------------------------------------------------------");
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);

            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);
        }

        public static void demo10()
        {
            Console.WriteLine("demo 9 class (DEMONSTRATION OF ACCESSING LISTS USING Accessing a List using LINQ ");
            Console.WriteLine("------------------------------------------------------------------------------");
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill" },
                new Student(){ Id = 2, Name="Steve" },
                new Student(){ Id = 3, Name="Ram" },
                new Student(){ Id = 4, Name="Abdul" },
                new Student(){ Id = 5, Name="Bill" }
        };

            //get all students whose name is Bill
            var studNames = from s in students
                            where s.Name == "Bill"
                            select s;

            foreach (var student in studNames)
                Console.WriteLine(student.Id + ", " + student.Name);
        }

        public static void demo11()
        {
            Console.WriteLine("demo 9 class (DEMONSTRATION OF List INSERTION USING INDEX ");
            Console.WriteLine("-------------------------------------------------------------");
            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.WriteLine(num);
        }
        public static void demo12()
        {
            Console.WriteLine("demo 12 class (DEMONSTRATION OF List whetehet the element is present or not "); Console.WriteLine("-------------------------------------------------------------");

            var numbers = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(numbers.Contains(10));
            Console.WriteLine(numbers.Contains(11));
            Console.WriteLine(numbers.Contains(20));
        }

        public static void demo14()
        {
            Console.WriteLine("demo 7 class (DEMONSTRATION OF remove  ELEMENT from list) ");
            Console.WriteLine("----------------------------------------------------------------------");


            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes 10 elements from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //removes the 3rd element (index starts from 0)

            foreach (var num in numbers)
                Console.WriteLine(num);

        }
    }
}

