using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    enum LayOffCause
    {
        VacationStockLessThanZero, AgeGreaterThanSixty, SalesTargetNotMet, Resignation
    }
    internal class Employee
    {
        public event Action<Employee, LayOffCause> EmployeeLayOff;

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        protected virtual void OnEmployeeLayOff(LayOffCause cause)
        {
            EmployeeLayOff?.Invoke(this, cause);
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
            int requestedDays = (To - From).Days + 1;
            VacationStock -= requestedDays;

            if (VacationStock < 0)
            {
                OnEmployeeLayOff(LayOffCause.VacationStockLessThanZero);
                return false;
            }
            return true;
        }
        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(LayOffCause.VacationStockLessThanZero);
            }
            else if ((DateTime.Now.Year - BirthDate.Year) > 60)
            {
                OnEmployeeLayOff(LayOffCause.AgeGreaterThanSixty);
            }
        }
    }
}
