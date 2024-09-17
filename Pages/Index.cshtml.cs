using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KeanuLapid.Models;
using System.Collections.Generic;

namespace KeanuLapid.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Employee> Employees { get; set; } = new List<Employee>();

        [BindProperty]
        public List<Manager> Managers { get; set; } = new List<Manager>();

        [BindProperty]
        public string ManagerName { get; set; } = string.Empty;
        [BindProperty]
        public string ManagerPosition { get; set; } = string.Empty;
        [BindProperty]
        public decimal ManagerSalary { get; set; }
        [BindProperty]
        public decimal ManagerBonus { get; set; }
        public decimal TotalManagerSalary { get; set; } = 0;

        public void OnGet()
        {
            // Sample data for Employees
            Employees.Add(new Employee("Tantan Rosel", "Manager", 55000));
            Employees.Add(new Employee("JP Asuncion", "Analyst", 48000));

            // Sample data for Managers
            Managers.Add(new Manager("Keanu Lapid", "Senior Manager", 70000, 10000));
            Managers.Add(new Manager("Drex Macaspac", "Project Manager", 60000, 8000));
        }

        public void OnPostCalculate()
        {
            // Create a new Manager and calculate total salary
            var manager = new Manager(ManagerName, ManagerPosition, ManagerSalary, ManagerBonus);
            TotalManagerSalary = Manager.CalculateTotalSalary(manager); // Use the method to calculate total salary

            // Optionally, you can add the new manager to the list
            Managers.Add(manager);
        }
    }
}
