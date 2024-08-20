using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }

        public List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }
        public void RemoveMember(Employee employee, LayOffCause cause)
        {
            if (cause == LayOffCause.VacationStockLessThanZero)
            {
                Members.Remove(employee);
            }
        }
    }
}
