using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public Department? Department { get; set; }

        public override string ToString()
        {
            return $"EmployeeID: {this.EmployeeID}, Name: {this.EmployeeName}, DepartmentID: {Department?.DepartmentID}, DepartmentName: {Department?.DepartmentName}";
        }
    }
}
