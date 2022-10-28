using DelegateNothers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateNothers.EmployeeSeparator;

namespace DelegateNothers
{
   
    class EmployeeSeparator
    {
        public delegate void EmployeeSeparatedEventHandler();
        public event EmployeeSeparatedEventHandler EmployeeSeparated;

        public void Separate()
        {
            if (EmployeeSeparated != null)
            {
                EmployeeSeparated();
            }
        }
    }
   
    internal class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;

        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        public void EmployeeSeparatedEventHandler()
        {
            Console.WriteLine("Finance Department : employee separation");
        }


    }
    internal class EventDemo
    {
 
        internal static void testEvent()
        {
            EmployeeSeparator employeeSeparator = new EmployeeSeparator();
            Finance finance = new Finance(employeeSeparator);
            employeeSeparator.Separate();
        }
    }
}
