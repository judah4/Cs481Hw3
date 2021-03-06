﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cs481Hw3
{
    public partial class Page2 : ContentPage, IQuestionPage
    {
        public QuestionData Question { get; set; }
        public List<QuestionData> Questions { get; set; }

        public Page2(List<QuestionData> questions)
        {
            Questions = questions;
            InitializeComponent();

            Question = new QuestionData()
            {
                QuestionText = "Who invented C++ ?",
                CorrectAnswer = "Bjarne Stroustrup"
            };
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
            Navigation.PushAsync(new Page3(Questions));

        }
    }
}
