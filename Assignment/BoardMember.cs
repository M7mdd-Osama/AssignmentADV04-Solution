using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(LayOffCause.Resignation);
        }

        protected override void OnEmployeeLayOff(LayOffCause cause)
        {
            if (cause == LayOffCause.AgeGreaterThanSixty || cause == LayOffCause.VacationStockLessThanZero)
            {
                return;
            }
            base.OnEmployeeLayOff(cause);
        }
    }
}
