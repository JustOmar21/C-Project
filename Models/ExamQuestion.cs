using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class ExamQuestion
    {
        public int Id {  get; set; }
        public int QuestionId {  get; set; }
        public int ExamId {  get; set; }
        public int Degree {  get; set; }

        public Question Question { get; set; }
        public Exam Exam { get; set; }
        public virtual ICollection<StudentAnswer>? Answers { get; set; }

        // Add constraint so that Degree > 0 Status:Done

    }
}
