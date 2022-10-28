using BasicsCSharp;
using static basicCsharp.Sonytv;

namespace basicCsharp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            reflections.demo56();
            reflection2.demo34();
           // reflections.demo3();
            //AbstractClassDemo.testAbstractClass();
            //InterfaceDemo.interfaceDemo();
            // methodOverload.testOverLoad();

            // MethodOveride.testMethodOveride();

            //Console.WriteLine("Hello, World!");
            //add();
            //datatypes();
            // explictTypeconversion();
            //Operators.ap();
            //Operators.logicalOpeartor();
            //Test.greet();
            //Test test = new Test();
            // test.info();
            //loops.whileLoop();
            //loops.forLoop();
            //loops.breakst();
            //loops.cnt();
            //arrays.array();
            /*Console.WriteLine("Products are : ");
            product product1 = new product();
            product1.code = 01;
            product1.name = "MOBILE";
            product1.desc = "the brand new mobile with 10 gb ";
            product1.supplier = "Nokia";
            product1.price = 40000;
            String info1 = product1.info();
            Console.WriteLine(info1);
            product product2 = new product();
            product2.code = 02;
            product2.name = "LAPTOP";
            product2.desc = "the brand new mobile with intel processor gb ";
            product2.supplier = "intel";
            product2.price = 80000;
            String info2 = product2.info();
            Console.WriteLine(info2);
            Console.WriteLine("----------------------------------------------------------------------------------------");
           
            Console.WriteLine("printing using Costructors");
            Console.WriteLine("-------------------------------------------");
            customer cust1 = new customer(01, "Ron", "ron@gmail.com", "78787878", "Bengaluru");
            Console.WriteLine(cust1.info());
            cust1.country = "India";
            Console.WriteLine("COUNTRY : " + cust1.country);
            cust1.zipcode = "562159";//prop set method 
            Console.WriteLine("ZIP CODE : " + cust1.zipcode);// prop get method 
            Console.WriteLine("-------------------------------------------");
*/
            /*  Car car1 = new Car();
              car1.name = "SUV";
              car1.model = "creation";
              car1.color = "black";
              car1.make = "Hyndai";
              car1.price = 17000000;
              car1.ac = "Kensatr";
              Console.WriteLine("-------------------------------------------");
              car1.start();
              Console.WriteLine(car1.info());
              Console.WriteLine("-------------------------------------------");
              car1.move();
              Console.WriteLine(car1.info());
              Console.WriteLine("-------------------------------------------");
              car1.move();
              Console.WriteLine(car1.info());
              Console.WriteLine("-------------------------------------------");
              car1.stop();
              Console.WriteLine(car1.info());
              Console.WriteLine("-------------------------------------------");*/

        }

        static void add()
        {
            int n1 = 100;
            int n2 = 100;
            int n3 = n1 + n2;
            Console.WriteLine(n3);
        }
        static void datatypes()
        {
            int n1 = 10;
            long l1 = 10L;
            float f1 = 100.0F;
            double d1 = 1000.0000;
            bool isActive = false;
            char chr = 'A';
            String course = "C#programming";
            Console.WriteLine("int n1=" + n1);
            Console.WriteLine(" long l1=" + l1);
            Console.WriteLine($"f1-{f1}:d1-{d1}");
            Console.WriteLine("bool=" + isActive);
        }
        static void explictTypeconversion()
        {
            int n1 = 10;
            double d1 = n1;
            Console.WriteLine($"int n1{n1}:double d1 {d1} ");
            float f1 = 1000.0000F;
            double d2 = f1;
            Console.WriteLine($" float f1{f1}: double d2 {d2} ");
        }
    }
}