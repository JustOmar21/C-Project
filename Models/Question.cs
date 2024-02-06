using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class Question
    {
        public int Id { get; set; }
        public required string Body {  get; set; }
        public required string Type { get; set; }
        public required int CorrectChoiceNumber {  get; set; }
        public int CourseId {  get; set; }
        public int? InstructorId { get; set; }
        public Course Course { get; set; }
        public Instructor? Instructor { get; set; }
        public virtual ICollection<QuestionChoices> Choices { get; set; }
        public virtual ICollection<ExamQuestion>? ExamQuestions { get; set; }

        // Add Constraint so that CorrectChoiceNumber is between 1 and 4 Status:Done
        // Add Constraint so that Type can only be MCQ or TF(True/False) Status:Done
        // Remember no matter what type the question is, always set 4 choices even if it is true/false , for true/false last two choices are null
    }
}
