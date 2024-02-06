using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class StudentExam
    {
        public int Id { get; set; }
        public int StudentId {  get; set; }
        public int ExamId {  get; set; }
        public int Degree {  get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public virtual ICollection<StudentAnswer> Answers { get; set; }


        // Add constraint so that Degree >= 0 Status:Done
        // Add composite Unique { StudentId , ExamId } Status:Done
        /* 
         Remember that you cannot add a student to an Exam if it doesn't have 10 questions OR
         total degree is < Course.MinDegree or > Course.MaxDegree
        */
    }
}
