using System;
using System.Collections.Generic;

using TourBookingApp.Views;
using Xamarin.Forms;

namespace TourBookingApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LocationPage), typeof(LocationPage));
            
        }
    }
}
