using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class StudentAnswer
    {
        public int ExamQuestionId { get; set; }
        public int StudentExamId { get; set; }
        public int? Answer { get; set; }

        public ExamQuestion ExamQuestion { get; set; }
        public StudentExam StudentExam { get; set; }
        
        // Add composite primary key {ExamQuestionId , StudentExamId} Status:Done
    }
}
