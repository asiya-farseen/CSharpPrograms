using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class dict
    {
        public static void demo1()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key/value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");
            Console.WriteLine("DEMONSTRATION OF DICTIONARY ");
            Console.WriteLine("--------------------------------------------------");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
            {"UK","London, Manchester, Birmingham"},
            {"USA","Chicago, New York, Washington"},
            {"India","Mumbai, New Delhi, Pune"}
        };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

        }
        public static void demo2()
        {

            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DEMONSTRATION OF ACCESING ELEMENST FROM THE DICTIONARY");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("---access elements using for loop---");
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }
        }




        public static void demo3()
        {

            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DEMONSTRATION OF UPDATING ELEMENST  IN THE DICTIONARY");
            Console.WriteLine("--------------------------------------------------");
            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
        }


        public static void demo4()
        {

            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("DEMONSTRATION OF REMOVING ELEMENST  IN THE DICTIONARY");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

        }
    }
}