using System.Collections.Generic;

namespace Cs481Hw3
{
    public interface IQuestionPage
    {
        QuestionData Question { get; set; }
        List<QuestionData> Questions { get; set; }
    }

    public struct QuestionData
    {
        public string QuestionText  { get; set; }
        public string CorrectAnswer  { get; set; }
        public string Answer { get; set; }
    }
}