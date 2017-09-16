using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cs481Hw3
{
    public partial class Page3 : ContentPage, IQuestionPage
    {
        public QuestionData Question { get; set; }
        public List<QuestionData> Questions { get; set; }

        public Page3(List<QuestionData> questions)
        {
            Questions = questions;
            Question = new QuestionData()
            {
                QuestionText = "Which of the following operator represents a conditional operation in C#?",
                CorrectAnswer = "?:"
            };
            InitializeComponent();


            QLabel.Text = Question.QuestionText;

        }

        void Answer(Button button)
        {
            Questions.Add(Question.Anwser(button.Text));
            Continue();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Answer((Button) sender);
        }

        public void Continue()
        {
            Navigation.PushAsync(new Page4(Questions));
        }
    }
}
