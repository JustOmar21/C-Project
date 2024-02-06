using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project.Models
{
    internal class QuestionChoices
    {
        public int QuestionId { get; set; }
        public required int ChoiceNumber {  get; set; }
        public string? Choice {  get; set; }
        public Question Question { get; set; }

        // Add Constraint so that choice number must be only between 1 and 4 Status: Done
        // Add Composite Key {QuestionId , ChoiceNumber} Status:Done
    }
}
