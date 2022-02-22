using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBookingApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TourBookingApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacesDisplay : ContentView
    {
        public PlacesDisplay()
        {
            InitializeComponent();
        }

        #region Name
        public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(PlacesDisplay), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as PlacesDisplay;
            if (newV != null && !(newV is string)) return;
            var oldName = (string)old;
            var newName = (string)newV;
            me?.NameChanged(oldName, newName);
        });

        private void NameChanged(string oldName, string newName)
        {
            NameLabel.Text = newName;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        #endregion


        #region Location
        public static readonly BindableProperty LocationProperty = BindableProperty.Create(nameof(Location), typeof(string), typeof(PlacesDisplay), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as PlacesDisplay;
            if (newV != null && !(newV is string)) return;
            var oldLocation = (string)old;
            var newLocation = (string)newV;
            me?.LocationChanged(oldLocation, newLocation);
        });

        private void LocationChanged(string oldLocation, string newLocation)
        {
            LocationLabel.Text = newLocation;
        }

        /// <summary>
        /// Location
        /// </summary>
        public string Location
        {
            get => (string)GetValue(LocationProperty);
            set => SetValue(LocationProperty, value);
        }
        #endregion


        #region Ratings
        public static readonly BindableProperty RatingsProperty = BindableProperty.Create(nameof(Ratings), typeof(double), typeof(PlacesDisplay), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as PlacesDisplay;
            if (newV != null && !(newV is double)) return;
            var oldRatings = (double)old;
            var newRatings = (double)newV;
            me?.RatingsChanged(oldRatings, newRatings);
        });

        private void RatingsChanged(double oldRatings, double newRatings)
        {
            RatingLabel.Text = newRatings.ToString();
        }

        /// <summary>
        /// Ratings
        /// </summary>
        public double Ratings
        {
            get => (double)GetValue(RatingsProperty);
            set => SetValue(RatingsProperty, value);
        }
        #endregion


        #region PlaceImage
        public static readonly BindableProperty PlaceImageProperty = BindableProperty.Create(nameof(PlaceImage), typeof(ImageSource), typeof(PlacesDisplay), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as PlacesDisplay;
            if (newV != null && !(newV is ImageSource)) return;
            var oldPlaceImage = (ImageSource)old;
            var newPlaceImage = (ImageSource)newV;
            me?.PlaceImageChanged(oldPlaceImage, newPlaceImage);
        });

        private void PlaceImageChanged(ImageSource oldPlaceImage, ImageSource newPlaceImage)
        {
            TheImage.Source = newPlaceImage;
        }

        /// <summary>
        /// PlaceImage
        /// </summary>
        public ImageSource PlaceImage
        {
            get => (ImageSource)GetValue(PlaceImageProperty);
            set => SetValue(PlaceImageProperty, value);
        }
        #endregion



    }
}