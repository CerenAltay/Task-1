using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee : HRDepartment
    {

        public decimal CalculateEmployeeSalary(int monthlyPay)
        {

            int OverTime = 0;
            int i = 1;
            int y = 1;

            do
            {
                do
                {
                    Console.WriteLine("Please Enter Overtime");
                    OverTime = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Press 5 to exit");
                    i = Convert.ToInt32(Console.ReadLine());
                }
                while (i != 5);


                Console.WriteLine("Please Enter Hours Worked");
                monthlyPay = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press 0 to exit");
                y = Convert.ToInt32(Console.ReadLine());


            } while (y != 0);

            return EmployeeSalary = monthlyPay + OverTime * 9;
        }

    }
}
