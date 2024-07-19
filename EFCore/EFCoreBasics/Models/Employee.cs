using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Employee
    {
        //[Key]
        public int EmployeeId { get; set; } //Primary Key

        //[Required]
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public long EmpSalary { get; set; }

        //One-To-One relationship with EmployeeDetails
        public EmployeeDetails EmployeeDetails { get; set; } //Reference Navigation property

        //One-To-Many relationship with Manager
        public int ManagerId { get; set; } //Foreign key property

        public Manager Manager { get; set; } //Reference Navigation Property to Manager

        public ICollection<EmployeeProject> EmployeeProjects { get; set; }//Collection Navigation Property


    }
}
