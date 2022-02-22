using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using TourBookingApp.Models;
using TourBookingApp.Views;
using Xamarin.Forms;

namespace TourBookingApp.ViewModels
{
    internal class HomePageViewModel  : BaseViewModel
    {
        public PlaceItemViewModel PlaceItemViewModel { get; set; } = new PlaceItemViewModel();

        

        private PlaceItem selectedPlace;

        public AsyncCommand<PlaceItem> SelectCommand { get; }

        public PlaceItem previouslySelectedItem { get; set; }

        

        public PlaceItem SelectedPlace
        {
            get { return selectedPlace; }
            set { if (value != null) {
                    previouslySelectedItem = value;
                    //value = null;
                }
                selectedPlace = value;
                OnPropertyChanged();
                    
            }
        }

        public HomePageViewModel()
        {
            SelectCommand = new AsyncCommand<PlaceItem>(Selected);
        }



        async Task Selected(PlaceItem place)
        {
            if (place == null)
                return;
            //await Application.Current.MainPage.DisplayAlert("Selected Place", place.Name, "OK");
            string route = $"{nameof(LocationPage)}?LocationIndex={place.Id}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
