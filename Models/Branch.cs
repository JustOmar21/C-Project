using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Branch
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Location { get; set; }

        public virtual ICollection<Department>? Departments { get; set;}
        public virtual ICollection<Class>? Classes { get; set;}
    }
}
