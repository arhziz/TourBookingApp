using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourBookingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void PlacesTapped(object sender, EventArgs e)
        {
            var TappedParrams = ((TappedEventArgs)e).Parameter;

            var route = $"{nameof(LocationPage)}?LocationIndex={TappedParrams}";
            Shell.Current.GoToAsync(route);
        }
    }
}