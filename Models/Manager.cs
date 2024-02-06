using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Manager
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Title { get; set; }
        public required string Email { get; set; }
        public required DateTime DOB { get; set; }
        public required double Salary { get; set; }

        // Add constraint so that DOB cannot be less than maybe 21 years old status: Done
        // Add constraint so that Salary cannot be less than 4000 (Min Wage lol) Status: Done
    }
}
