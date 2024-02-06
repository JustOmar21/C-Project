using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class TeachesAt
    {
        public required int CourseId { get; set; }
        public required int ClassId {  get; set; }
        public int? InstructorId {  get; set; }

        public Course Course { get; set; }
        public Class Class { get; set; }
        public Instructor? Instructor { get; set; }

        // Add composite key(CourseId , ClassId) Status:Done

    }
}
