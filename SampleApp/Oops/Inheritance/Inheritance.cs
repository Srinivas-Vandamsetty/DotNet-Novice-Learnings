using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Oops.Inheritance
{
    class Employee
    {
        public int EmpId;
        public string EmployeeName;
        public int EmployeeAge;
        public int EmployeeContact;

        public Employee(int empId, string employeeName, int employeeAge, int employeeContact)
        {
            EmpId = empId;
            EmployeeName = employeeName;
            EmployeeAge = employeeAge;
            EmployeeContact = employeeContact;
        }
    }



    class PermanantEmployee: Employee 
    
    {
        public int PermanantSalary;
        public int PermanantHours;

        public PermanantEmployee(int empId, string employeeName, int employeeAge, int employeeContact,
                                int permanantSalary, int permanantHours) : base(empId, employeeName, employeeAge, employeeContact) // Call base class constructor

        {
            PermanantSalary = permanantSalary;
            PermanantHours = permanantHours;

        }

    }


    class VisitingEmployee : Employee

    {
        public int VisitingSalary;
        public int VisitingHours;

        public VisitingEmployee(int empId, string employeeName, int employeeAge, int employeeContact, int visitingSalary, int visitingHours) : base(empId, employeeName, employeeAge, employeeContact) // Call base class constructor
        {
            VisitingSalary = visitingSalary;
            VisitingHours = visitingHours;
        }
    }

}
