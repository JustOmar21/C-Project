using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Class
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Floor {  get; set; }
        public int BranchId {  get; set; }
        public Branch Branch { get; set; }
        public virtual ICollection<Student>? Students { get; set; }
        public virtual ICollection<TeachesAt>? TeachesClass {  get; set; }
    }
}
