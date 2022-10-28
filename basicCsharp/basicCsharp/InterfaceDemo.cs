using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace basicCsharp
{
    
        internal interface IUniversalRemote
        {
            public void SwitchOn();
            public void SwitchOff();
       
      

        }
    internal class TCLTV : IUniversalRemote
    {
        bool tvstatus = false;
        
        public void SwitchOff()
        {
          
            if (!tvstatus)
            {
                tvstatus = true;
                Console.WriteLine(" TCLTV TV SWITCHED OFF");
            }
            else
            {
                Console.WriteLine(" TCLTV  TV SWITCHED OFF");
            }

        }
        public void SwitchOn()
        {
            if (!tvstatus)
            {
                tvstatus = true;
                Console.WriteLine("TV SWITCHED ONN");
            }
            else
            {
                Console.WriteLine("TV SWITCHED ONN");
            }
        }
    }
    internal class Sonytv : IUniversalRemote
    {
        bool tvstatus = false;
        int currentchannel = 1;
        public void SwitchOff()
        {
            if (!tvstatus)
            {
                tvstatus = true;
                Console.WriteLine("TV SWITCHED OFF");
            }
            else
            {
                Console.WriteLine("TV SWITCHED OFF");
            }

        }
        public void SwitchOn()
        {
            if (!tvstatus)
            {
                tvstatus = true;
                Console.WriteLine("TV SWITCHED ONN");
            }
            else
            {
                Console.WriteLine("TV SWITCHED ONN");
            }
        }
        
        internal class InterfaceDemo
        {
            public static void interfaceDemo()
            {
                IUniversalRemote iURemote = new Sonytv();
                iURemote.SwitchOff();
                iURemote.SwitchOn();
                
                

            }
        }

    }
    }
