using EFCoreBasics.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; } //Primary Key
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }

        //One-to-Many relationship with Employees 
        public ICollection<Employee> Employees { get; set; } //Collection Navigation property to represent the employees manager by the manager

    }
}
