using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email {  get; set; }
        public required DateTime DOB {  get; set; }
        public int? IntakeId {  get; set; }
        public int? TrackId {  get; set; }
        public int? ClassId {  get; set; }
        public Class? Class { get; set; }
        public Track? Track { get; set; }
        public Intake? Intake { get; set; }
        public ICollection<StudentExam>? Exams { get; set; }

        // Add constraint so that DOB cannot be less than maybe 15 years old status: Done
    }
}
