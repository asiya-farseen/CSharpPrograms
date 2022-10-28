using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    public static class arrays
    {
        public static void array()
        {
            string[] fruits = { "Bannana", "Guava", "Apple", "Mango" };
            Console.WriteLine("-----------------------");
            Console.WriteLine("Looping");
            Console.WriteLine("-----------------------");
            for (int k = 0; k < fruits.Length; k++)
            {
                Console.WriteLine(fruits[k]);
                
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("After update");
            Console.WriteLine("----------------------");
            fruits[0] = "Jack fruit";
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
                
            }
            Console.WriteLine("------------------");
            System.Array.Sort(fruits);
            Console.WriteLine("array after sorting");
            Console.WriteLine("------------------");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
               
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Integer array runs array ");
            int[] runs = new int[fruits.Length];
            runs[0] = 28;
            runs[1] = 20;
            runs[2] = 64;
            runs[3] = 18;
            //runs[4] = 15;
            Console.WriteLine("-------------------");
            foreach (int run in runs)
            {
                Console.WriteLine(run);
                

            }
            Console.WriteLine("---------------------");
            int max=runs.Max();
            Console.WriteLine("Maximun =" + max);
            Console.WriteLine("---------------------");
            int min = runs.Min();
            Console.WriteLine("Minium =" + min);
            Console.WriteLine("---------------------");
            int total = runs.Sum();
            Console.WriteLine("Total =" + total);
            Console.WriteLine("----------------------");
            System.Array.Sort(runs);
            Console.WriteLine("Array after sorting");
            Console.WriteLine("---------------------");
            foreach (int run in runs)
            {
                Console.WriteLine(run);
                
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("Reversed Array");
            Console.WriteLine("---------------------");
            System.Array.Reverse(runs);
            foreach (int run in runs)
            {
                Console.WriteLine(run);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("length of the given array RUNS is : "+runs.Length);
            Console.WriteLine("---------------------------------------------");
        }



    }
}
