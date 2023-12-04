﻿using Cinepolis_v2.Views;
using Cinepolis_v2.Controllers;


namespace Cinepolis_v2 {
    public partial class App : Application {
        public static API api = new API();


        public App() {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
