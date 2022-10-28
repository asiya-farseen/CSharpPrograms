using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLib
{
    public class ElectricityBill
    {

        public static double Caluclatebill(int unit)
        {

            if (unit <= 100)
            {

                return unit * 1;

            }
            else if (unit >= 100 && unit <= 200)
            {
                return (100 * 1) + (unit - 100) * 2;
            }
            else if (unit >= 200 && unit <= 300)
            {
                return (100 * 1) + (100 * 2) + (unit - 200) * 3;
            }


            else if (unit > 300)
            {
                return (100 * 1) + (100 * 2) + (100 * 3) + (unit - 300) * 5;
            }

            else
            {
                return 0;
            }


        }
        public static void demo()
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
