using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TestMvvM.Models
{
    public class QuestionAnswer
    {
        public string Question;
        public string Answer;

        public QuestionAnswer(string question)
        {
            Question = question;
            Answer = "";
        }
    }

    public class QuestionAnswerList
    {
        public LinkedList<QuestionAnswer> QuestionSet;

        public QuestionAnswerList()
        {
            QuestionSet = new LinkedList<QuestionAnswer>();
        }
    }
}
