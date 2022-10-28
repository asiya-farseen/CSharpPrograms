using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace project2
{
    internal class CWG
    {
        public int code { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public int gold { get; set; }
        public int silver { get; set; }
        public int bronze { get; set; }
        public int total { get; set; }

        public CWG(int code, string name, int year, int gold, int silver, int bronze, int total)
        {
            this.code = code;
            this.name = name;
            this.year = year;
            this.gold = gold;
            this.silver = silver;
            this.bronze = bronze;
            this.total = total;
            
        }

        public string info()
        {
            return $" Code : {code} Name : {name} Gold : {gold} Silver: {silver} Bronze: {bronze} Total: {total}";
        }
    }
    internal class CWGDemo
    {
        public static void csgAssignment()
        {
            var cwgList = new List<CWG>();
            cwgList.Add(new CWG(1, "Australia", 2022, 67, 57, 54, 178));
            cwgList.Add(new CWG(2, "England", 2022, 57, 66, 53, 176));
            cwgList.Add(new CWG(3, "Canada", 2022, 26, 32, 34, 92));
            cwgList.Add(new CWG(4, "India", 2022, 22, 16, 23, 61));
            cwgList.Add(new CWG(5, "New Zealand", 2022, 20, 12, 17, 49));
            Console.WriteLine("Display data of all countries");
            foreach (var cwg in cwgList)
            {
                Console.WriteLine(cwg.info());
            }

            int grandtotal = 0;

            foreach (var cwg in cwgList)
            {
                grandtotal = grandtotal + cwg.total;
            }

            Console.WriteLine("total medals won by all countries" + grandtotal);

            Console.WriteLine("Change India's medal");

            foreach (var cwg in cwgList)
            {
                if (cwg.name.Equals("India"))
                {
                    cwg.gold = cwg.gold + 2;
                    cwg.total = cwg.total + 2;
                    break;
                }
            }

            Console.WriteLine("Display after changing India's medal");
            foreach (var cwg in cwgList)
            {
                Console.WriteLine(cwg.info());
            }

            Console.WriteLine("Delete Australia data");
            int indexOfAustralia = -1;
            foreach (var cwg in cwgList)
            {
                if (cwg.name.Equals("Australia"))
                {
                    indexOfAustralia = cwgList.IndexOf(cwg);
                    break;
                }
            }
            cwgList.RemoveAt(indexOfAustralia);

            Console.WriteLine("Display after deleting Austalia's data");
            foreach (var cwg in cwgList)
            {
                Console.WriteLine(cwg.info());
            }

        }
    }
}