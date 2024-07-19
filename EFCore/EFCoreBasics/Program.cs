// See https://aka.ms/new-console-template for more information
using EFCoreBasics.Data;
using EFCoreBasics.Models;

Console.WriteLine("Hello, World!");

using (var context = new AppDbContext())
{
    //Insert Manager Details
    //var manager = new Manager();
    //manager.EmpLastName = "G"; ;
    //manager.EmpFirstName = "Ravi";

    //context.Managers.Add(manager);
    //context.SaveChanges();

    var employee = new Employee();
    employee.EmpLastName = "Sahana"; ;
    employee.EmpFirstName = "Bhat";
    employee.EmpSalary = 100000;
    employee.ManagerId = 1;

    context.Employees.Add(employee);
    context.SaveChanges();
}
