using CritografoMVVM_RLG.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CritografoMVVM_RLG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new critografo();
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
