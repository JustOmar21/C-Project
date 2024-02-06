using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Intake
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime StartTime { get; set; }
        public required DateTime EndTime { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

        // Add Constraint so that StartTime is always < EndTime   Status: Done
        // Add Constraint so that StartTime and EndTime are within the 5 years range from current time Status: Done
        // Add Constraint so that difference between StartTime and EndTime is at least 3 Months Status: Done
    }
}
