namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department { DeptID = 1, DeptName = "CS" };
            Club club = new Club { ClubID = 1, ClubName = "Sports" };

            Employee Emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1960, 1, 1), VacationStock = 5 };
            SalesPerson Emp2 = new SalesPerson { EmployeeID = 2, BirthDate = new DateTime(1980, 1, 1), VacationStock = 10, AchievedTarget = 80 };
            BoardMember Emp3 = new BoardMember { EmployeeID = 3, BirthDate = new DateTime(1950, 1, 1) };

            dept.AddStaff(Emp1);
            dept.AddStaff(Emp2);
            dept.AddStaff(Emp3);

            club.AddMember(Emp1);
            club.AddMember(Emp2);
            club.AddMember(Emp3);

            Emp1.RequestVacation(new DateTime(2024, 8, 1), new DateTime(2024, 8, 10));
            Emp2.CheckTarget(100);
            Emp3.Resign();

            Emp1.EndOfYearOperation();

            Console.WriteLine("Department Staff : " + dept.Staff.Count);
            Console.WriteLine("Club Members : " + club.Members.Count);
        }
    }
}
