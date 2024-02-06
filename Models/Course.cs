using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public int MaxDegree {  get; set; }
        public int MinDegree { get; set; }
        public virtual ICollection<Exam>? Exams { get; set; }
        public virtual ICollection<Question>? QuestionPool { get; set; }
        public virtual ICollection<TeachesAt>? TeachesClass { get; set; }

        // Add constriant so that MaxDegree cannot be < Min Degree Status: Done
        // Add constraint so that MinDegree cannot be less than 0 Status: Done
    }
}
