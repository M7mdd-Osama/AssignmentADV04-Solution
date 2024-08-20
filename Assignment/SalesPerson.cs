using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(LayOffCause.SalesTargetNotMet);
                return false;
            }
            return true;
        }
        protected override void OnEmployeeLayOff(LayOffCause cause)
        {
            if (cause == LayOffCause.VacationStockLessThanZero)
            {
                return;
            }
            base.OnEmployeeLayOff(cause);
        }
    }
}
