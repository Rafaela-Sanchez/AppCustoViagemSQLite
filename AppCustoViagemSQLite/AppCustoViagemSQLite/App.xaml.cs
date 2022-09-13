using System;
using System.Threading;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCustoViagemSQLite.View;

namespace AppCustoViagemSQLite
{
    public partial class App : Application
    {
        public List<Model.Pedagio> ListaPedagios = new List<Model.Pedagio>();
        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            MainPage = new NavigationPage(new TelaInicial());
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
