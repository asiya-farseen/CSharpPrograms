using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class reflection2
    {

     

        // Define a class Student
        class Student
        {

            // Properties definition
            public int RollNo
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            // No Argument Constructor
            public Student()
            {
                RollNo = 0;
                Name = string.Empty;
            }

            // Parameterised Constructor
            public Student(int rno, string n)
            {
                RollNo = rno;
                Name = n;
            }

            // Method to Display Student Data
            public void displayData()
            {
                Console.WriteLine("Roll Number : {0}", RollNo);
                Console.WriteLine("Name : {0}", Name);
            }
        }

        public static void demo34()
        { 

         
                Assembly executing = Assembly.GetExecutingAssembly();

                // Array to store types of the assembly
                Type[] types = executing.GetTypes();
                foreach (var item in types)
                {
                    // Display each type
                    Console.WriteLine("Class : {0}", item.Name);

                    // Array to store methods
                    MethodInfo[] methods = item.GetMethods();
                    foreach (var method in methods)
                    {
                        // Display each method
                        Console.WriteLine("--> Method : {0}", method.Name);

                        // Array to store parameters
                        ParameterInfo[] parameters = method.GetParameters();
                        foreach (var arg in parameters)
                        {
                            // Display each parameter
                            Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                    arg.Name, arg.ParameterType);
                        }
                    }
                }
            }
        }
    }

