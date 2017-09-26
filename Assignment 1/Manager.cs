using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Manager : Employee
    {

        public int AddManager(int employeeId)
        {

            EmployeeId = employeeId;
            while (EmployeeId < 3 && EmployeeId > 0)
            {
                while (EmployeeName == null)
                {
                    Console.WriteLine("Please Enter Manager Name");
                    EmployeeName = Console.ReadLine();
                }
                EmployeeId++;
            }

            if (EmployeeName == null)
                return -1;
            else
                return 1;
        }
    }
}
