using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Cs481Hw3
{
    public partial class App : Application
    {

        public NavigationPage NavPage { get; set; }

        public App()
        {
            InitializeComponent();

            NavPage =  new NavigationPage();
            NavPage.PushAsync(new Cs481Hw3.MainPage(this));
            MainPage = NavPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
