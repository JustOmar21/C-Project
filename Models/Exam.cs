using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Exam
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime StartTime { get; set; }
        public required DateTime EndTime { get; set; }
        public int? InstructorId { get; set; }
        public int CourseId { get; set; }

        public Instructor? Instructor { get; set; }
        public Course Course { get; set; }
        public virtual ICollection<ExamQuestion>? ExamQuestions { get; set; }
        public virtual ICollection<StudentExam>? Students { get; set; }

        // Add Constraint so that StartTime is always < EndTime   Status: Done
        // Add Constraint so that StartTime and EndTime are within the 10 years range from current time Status:Done
        // Add Constraint so the StartTime and EndTime are at least 1 hour apart and at max 4 hours and occur at the same day Status:Done
    }
}
