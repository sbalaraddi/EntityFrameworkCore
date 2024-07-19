using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBasics.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; } //Primary Id
        public string Address { get; set; }
        public string PhonNumber { get; set; }
        public string Email { get; set; }

        public int EmployeeId { get; set; } //Foreign Key
        public Employee Employee { get; set; } //Reference Navigation property

    }
}
