using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; } //Primary key
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; set; } //Collection Navigation Property

    }
}
