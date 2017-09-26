using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Contractor
    {

        public static decimal CalculateContractorSalary(int hoursWorked)
        {
            for (int i = 1; i < 2; i++)
            {

                foreach (DayOfWeek days in Enum.GetValues(typeof(DayOfWeek)))
                {
                    Console.WriteLine("Please enter the hours of contractor for {0} for week {1}", days, i);
                    hoursWorked = hoursWorked + Convert.ToInt32(Console.ReadLine());
                }

            }
            return hoursWorked * 9;
        }
    }
}
