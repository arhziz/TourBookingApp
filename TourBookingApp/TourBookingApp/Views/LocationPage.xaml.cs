using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TourBookingApp.ViewModels;

namespace TourBookingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(LocationIndex),nameof(LocationIndex))]
    public partial class LocationPage : ContentPage
    {
        public string LocationIndex { get; set; }
        public LocationPage()
        {
            InitializeComponent();
        }

        protected override  void OnAppearing()
        {
            base.OnAppearing();

            int.TryParse(LocationIndex, out var result);

            BindingContext = PlaceItemViewModel.Instance.Places[result];


            ReviewsLabel.Text = ReviewsLabel.Text + " reviews";

            TempLabel.Text = TempLabel.Text + "°C";
        }

        private async void BackButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }



       


    }
}