using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs481Hw3
{
    public static class QuestionPageExtensions
    {
        public static QuestionData Anwser(this QuestionData question, string answer)
        {
            question.Answer = answer;
            return question;
        }

    }
}
