namespace KeanuLapid.Models
{
    public class Employee
    {
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        // Default constructor
        public Employee()
        {
        }
    }

    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public Manager(string name, string position, decimal salary, decimal bonus)
            : base(name, position, salary)
        {
            Bonus = bonus;
        }

        // Default constructor
        public Manager()
        {
        }

        // Overload the + operator to calculate total salary
        public static decimal CalculateTotalSalary(Manager manager)
        {
            return manager.Salary + manager.Bonus;
        }
    }
}
