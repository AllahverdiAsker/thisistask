using System;
using System.Collections.Generic;
using System.Text;

namespace thisistask.yeni
{
    class Department
    {

        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        public string[] Employees = new string [0];
        public Department(int salarylimit,int employeelimit)
        {
            SalaryLimit = salarylimit;
            EmployeeLimit = employeelimit;
        }
        

        public void AddEmployee(string employee)
        {
            if (employee.Length < SalaryLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }

        }


    }
}
