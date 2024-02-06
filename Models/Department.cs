using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public int BranchId {  get; set; }

        public Branch Branch { get; set; }
        public virtual ICollection<Track>? Tracks { get; set; }
    }
}
