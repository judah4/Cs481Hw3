using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cs481Hw3
{
    public partial class Page1 : ContentPage, IQuestionPage
    {
        public QuestionData Question { get; set; }
        public List<QuestionData> Questions { get; set; }


        public Page1(List<QuestionData> questions)
        {
            InitializeComponent();
            Questions = questions;
            Question = new QuestionData()
            {
                QuestionText = "At Dartmouth College in 1964 John Kemeny and Thomas Kurtz invented ... ?",
                CorrectAnswer = "Basic"
            };
            QLabel.Text = Question.QuestionText;
            
        }

        void Answer(Button button)
        {
            Questions.Add(Question.Anwser(button.Text));

            Continue();
        }


        private void Button1_OnClicked(object sender, EventArgs e)
        {
            Answer((Button) sender);
        }
        private void Button2_OnClicked(object sender, EventArgs e)
        {
            Answer((Button) sender);
        }
        private void Button3_OnClicked(object sender, EventArgs e)
        {
            Answer((Button) sender);
        }

        public void Continue()
        {
            Navigation.PushAsync(new Page2(Questions));

        }

    }
}
