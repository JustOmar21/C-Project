using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Track
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId {  get; set; }
        public Department Department { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
    }
}
