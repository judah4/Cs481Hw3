using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cs481Hw3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Results : ContentPage
    {
        public List<QuestionData> Questions { get; set; }

        public Results(List<QuestionData> questions)
        {
            Questions = questions;
            InitializeComponent();

            for (int cnt = 0; cnt < Questions.Count; cnt++)
            {
                MyGrid.Children.Add(new Label() {Text = Questions[cnt].QuestionText}, 0, cnt+1);
                MyGrid.Children.Add(new Label() {Text = Questions[cnt].Answer}, 1, cnt+1);
                MyGrid.Children.Add(new Label() {Text = Questions[cnt].CorrectAnswer}, 2, cnt+1);
            }
           

        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}