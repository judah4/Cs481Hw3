using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cs481Hw3
{
    public partial class MainPage : ContentPage
    {
        List<QuestionData> _questions = new List<QuestionData>();

        public MainPage(App app)
        {
            InitializeComponent();

            app.NavPage.Popped += (sender, args) =>
            {
                if(_questions.Count > 0)
                    _questions.RemoveAt(_questions.Count-1);
            };

            app.NavPage.PoppedToRoot += (sender, args) =>
            {
                _questions.Clear();
            };
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            _questions.Add(new QuestionData()
            {
                QuestionText = "Your name?",
                Answer = NameEntry.Text,
            });

            Navigation.PushAsync(new Page1(_questions));
        }
    }
}
