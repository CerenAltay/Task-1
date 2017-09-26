using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class HRDepartment
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        enum DaysOfWeek { Mon, Tue, Wed, Thurs, Fri };

        private string SearchEmployeeName(int ID)
        {
            Employee Staff = new Employee();
            Staff.EmployeeId = 132;
            Staff.EmployeeName = "Jamie Oliver";

            if (ID > 1 && ID < 132)
            {
                if (ID == 11)
                {
                    return "Jason Wellington";
                }
                else if (ID == 12)
                {
                    return "Alison Hill";
                }
                else
                {
                    return "Ceren Altay";
                }

            }
            if (ID < 1)
            {
                return "No such ID";

            }
            if (ID > 132)
            {
                return "ID out of range";


            }

            if (ID == Staff.EmployeeId)
            {
                return Staff.EmployeeName;

            }

            return "Error on finding employee";

        }


        static void Main(string[] args)
        {

            Employee employee = new Employee();

            //inherited private method
            string name = employee.SearchEmployeeName(12);

            Console.WriteLine("Employee Name is {0}", name);
            Console.WriteLine();

            //public method       
            decimal salary = employee.CalculateEmployeeSalary(1200);
            Console.WriteLine("Employee Salary is {0}", salary);
            Console.WriteLine();

            //static method
            decimal contractorSalary = Contractor.CalculateContractorSalary(0);
            Console.WriteLine("Contractor Salary is {0}", contractorSalary);
            Console.WriteLine();

            //method returning minus value
            Manager manager = new Manager();
            int added = manager.AddManager(3);

            if (added == 1)
            {
                Console.WriteLine("Manager Added");
            }

            else if (added == -1)
            {
                Console.WriteLine("Manager couldnt be added, please change the EmployeeId to 2");
            }

            Console.ReadKey();



        }
    }
}
