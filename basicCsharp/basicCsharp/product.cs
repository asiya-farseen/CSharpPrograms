using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class product
    {
        //Proprties
        public int code;
        public String name;
        public String desc;
        public String supplier;
        public float price;

        public string info()
        {
            
            Console.WriteLine("---------------------------------------------------------------------------------");
            
            return " Code : " + code + "\n Name : " + name + "\n Description : " + desc + "\n Supplier : " + supplier + "\n price : " + price;
        }
    }
}
