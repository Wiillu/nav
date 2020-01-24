using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nav
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //declaramos que la app sera con navegacion
            NavigationPage vanPag = new NavigationPage(MainPage());

            MainPage = vanPag;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
