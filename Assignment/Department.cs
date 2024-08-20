using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        public void RemoveStaff(Employee employee, LayOffCause cause)
        {
            if (cause == LayOffCause.VacationStockLessThanZero || cause == LayOffCause.AgeGreaterThanSixty)
            {
                Staff.Remove(employee);
            }
        }
    }
}
