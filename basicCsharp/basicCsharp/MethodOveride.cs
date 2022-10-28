using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCsharp
{
    internal class RBI
    {
        public float roi = 0F;
        public virtual float rateOfInterest()
        {
            roi = 5F;
            return roi;
        }
    }
    internal class SBI : RBI
    {

        public override float rateOfInterest()
        {
            roi = 5F;
            return roi;
        }
    }

    internal class KarnatakaBank : RBI
    {
        public float rateOfInterest()
        {
            roi = 7F;
            return roi;
        }
        public void info()
        {
            Console.WriteLine("i am karnataka bank");
        }
    }

    internal class MethodOveride
    {
        public static void testMethodOveride()
        {
            RBI rbi = new SBI();
            float rate = rbi.rateOfInterest();
            Console.WriteLine("SbI rate of inetset" + rate);
            rbi = new KarnatakaBank();
            rate = rbi.rateOfInterest();
            Console.WriteLine("karnataka bank rate of interest is " + rate);
        }
    }
}
    
