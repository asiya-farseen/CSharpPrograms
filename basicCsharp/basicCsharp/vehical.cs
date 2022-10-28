using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class vehical
    {
        public String name;
        public String model;
        public String make;
        public String color;
        public float price;
        public int speed;
        public void start()
        {
            Console.WriteLine("vehical is gettin started");
            this.speed = 0;


        }
        public void stop()
        {
            Console.WriteLine("vehical is gettin started");
            this.speed = 0;


        }
        public void move()
        {
            Console.WriteLine("vehical is gettin started");
            this.speed = this.speed + 5;


        }
        public String info()
        {
            return $"NAME : {this.name} \nMODEL : {this.model} \nMAKE : {this.make} \nCOLOR : {this.color} \nPRICE : {this.price} \nSPEED : {this.speed}";
        }
    }
        internal class Car:vehical
        {
           public String ac;
            public void move()
            {
                Console.WriteLine("vehical is gettin started");
                this.speed = this.speed + 10;


            }


        }
    }

