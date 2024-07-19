using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    //Join table class for Employee and Project
    public class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } //Reference Navigation Property

        public int ProjectId { get; set; }

        public Project Project { get; set; } //Reference Navigation Property
    }
}
