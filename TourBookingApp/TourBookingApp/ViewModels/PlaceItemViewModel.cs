using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TourBookingApp.Models;
using Xamarin.CommunityToolkit.ObjectModel;
using TourBookingApp.Views;
using Xamarin.Forms;

namespace TourBookingApp.ViewModels
{
    //the place view model
    internal class PlaceItemViewModel
    {
        //lists of the current places on the app
        public static PlaceItemViewModel Instance;

        public AsyncCommand<PlaceItem> SelectedCommand { get; }
        
        public ObservableCollection<PlaceItem> Places { get; set; } = new ObservableCollection<PlaceItem> {
                new PlaceItem { Id=0, Name="Santa Monica State Beach", Location="USA, California", Ratings=4.3, AvgPrice=120, Temperature=25, Images= new List<string>(){ "santamonic", "santamonica1", "santamonica2","santamonica3" }, Categories = TourEnums.Categories.Beach, Reviews=504, PlaceDesc = new List<string>(){ "Jutting out into the Pacific Ocean at the intersection of Ocean and Colorado, it symbolizes the heart of Santa Monica and is one of the most photographed locations in the world.", "Discover more than just a Pier, we are a destination where people come together to enjoy local culture and to reconnect with the Pier’s storied past. Whether you are here to take in the incredible views, ride Pacific Park’s Ferris Wheel, hosting an event, or joining us for another family-friendly activity, we can’t wait to welcome you to the Santa Monica Pier." } },
                new PlaceItem {Id=1, Name="Canggu Beach", Location="Indonesia, Bali", Ratings=4.8, AvgPrice=100, Temperature=30, Images= new List<string>(){ "canggu", "canggu1", "canggu2", "canggu3" },  Categories = TourEnums.Categories.Beach, Reviews=453, PlaceDesc = new List<string>(){ "Canggu Beach is North of Seminyak. It's mostly famous as a place for surfing with 2 famous beaches : Echo Beach, world class wave and Batu Bolong also known as Old Man which is the ideal spot for beginners, longboards and funboards.", "Those 2 beaches are reef breaks.The sand is black on the 2 beaches, but it's also a nice place to rest and watch the surfers.", "In the past year Batu Bolong has became a super trendy place with many young European hanging out in the evening.", "The new athmosphere reminds a bit of Ubud, but with the surf as a background." } },
                new PlaceItem {Id=2, Name="Cathedral Cove", Location="New Zealand", Ratings=4.6, AvgPrice=80, Temperature=28,  Images= new List<string>(){ "cathedral", "cathedral1", "cathedral2", "cathedral3" },  Categories = TourEnums.Categories.Beach, Reviews=639, PlaceDesc = new List<string>(){ "Hahei is the home of NZ Must-Do; Cathedral Cove, and a seaside village with a beautiful beach of its own. Foot access to Cathedral Cove starts at the top of Grange Road.", "Parking is at the Visitor Car Park on Pa Road (turn right just after entering Hahei). During the summer months a shuttle service runs from the visitor car park on Pa Road to the start of the Cathedral Cove track. It only costs $5 return per person, $3 for a child and $10 for a family (2 adults 2 children). It is recommended that all visitors to Hahei Beach and Cathedral Cove use this car park.", "The top car park (Grange Road) is a pick up and drop off zone for the Shuttle only. Parking is prohibited at Grange Rd from the 1 October - 30 April. Limited parking is available on Grange Rd from 1 May - 30 September at $15 for 4 hours.", "For visitors with impaired mobility, a viewing platform is accessible by ramp from the main carpark. Although you cannot see the cove from here, there are stunning views over the volcanic coastline and information panels to narrate the story unfolding in front of you." } },
                new PlaceItem {Id=3, Name="Maya Bay", Location="Thailand", Ratings=4.5, AvgPrice=70, Temperature=27, Images= new List<string>(){ "maya", "maya1", "maya2", "maya3" },  Categories = TourEnums.Categories.Beach, Reviews=742, PlaceDesc = new List<string>(){ "Maya Bay is a stunningly beautiful bay that's sheltered by 100-metre high cliffs on three sides. Inside the bay there are several beaches, most are small and some only exist at low tide. The main one is around 200 metres long with silky soft white sand, underwater colourful coral and exotic fish in exceptionally clear water; the whole bay is one big reef.", "Maya Bay has become the main tourist attraction of Phi Phi since The Beach was filmed here in 1999. It was always very popular before the film but now people around the world who haven't even heard of Phi Phi have certainly heard of Maya Bay.", "You can only visit Maya Bay from November to April, as large waves make the entrance dangerous for boats during the other months of the year.", "The bad news; as it's so beautiful and so well known many boats are required to ferry all the visitors in and out. On any given day at any time there will be 30 + speedboats and longtail boats on the beach, with large ferry boats carrying hundreds of snorkelers and sightseers moored in deeper water. Beautiful it is, secluded it isn't – thousands of people visit each day. Try to visit early in the morning or after 17:00 and you'll avoid the crowds." } },
                new PlaceItem {Id=4, Name="Matira Beach", Location="Bora Bora", Ratings=4.5, AvgPrice=50, Temperature=24, Images= new List<string>(){ "matira", "matira1", "matira2", "matira3" },  Categories = TourEnums.Categories.Beach, Reviews=234, PlaceDesc = new List<string>(){ "Matira Beach is the largest public access beach in Bora Bora making it extremely popular with visitors. The water is crystal-clear and the sand is soft and downy. Matira Beach is also peppered with resorts, shops and eateries, so it's a convenient place to spend most of a day. ", "Travelers and locals alike have nothing but positive things to say about the beach. Most comment on the incredibly blue water and how the shoreline is rarely ever crowded making it the perfect place for some rest and relaxation. But save your snorkeling for another beach, as the shallow waters aren't the best for spotting sea life. If you don't have time to spend a whole day at the beach, many say the sunsets are at least worth a visit. ", "You'll find the beach about 5 miles south of Vaitape, and you can get there by bicycle or taxi. You can also drive there; you'll find parking spots near the InterContinental Bora Bora Le Moana Resort." } },
                new PlaceItem {Id=5, Name="Matterhorn", Location="Switzerland", Ratings=4.3, AvgPrice=60, Temperature=21, Images= new List<string>(){ "matterhorn", "matterhorn1", "matterhorn2", "matterhorn3" },  Categories = TourEnums.Categories.Mountain, Reviews=302, PlaceDesc = new List<string>(){ "Triangular. A cragged rock “tooth” ranging into the heavens. Standing alone on the horizon. A magnet for alpinists, aesthetic emblem, mountain with ideal proportions. Rugged rock with magical light. Playing in a sea of clouds and horizontal colouring. Seeing enough of the Matterhorn? Not possible!", "There are a wide variety of different attractions to be discovered around the Matterhorn. A top excursion is Gornergrat. On this three-thousand metre mountain ridge there is a viewing platform with a truly unforgettable view of the Matterhorn and the surrounding mountain world.", "Or if you prefer, the Matterhorn can also be admired from the Rothorn. The Matterhorn glacier paradise is the highest summer ski region in Europe and is open 365 days a year. And there is still plenty to do when the sun isn’t shining! The Matterhorn Museum explains the historic development of Zermatt from a mountain village to an Alpine holiday resort and also has many photographs and facts about the first ascent of the Matterhorn." }  } };


        private PlaceItem _SelecetedPlace;

        public PlaceItem SelecetedPlace
        {
            get { return _SelecetedPlace; }
            set { _SelecetedPlace = value; }
        }


        public PlaceItemViewModel()
        {
            Instance = this;
            SelectedCommand = new AsyncCommand<PlaceItem>(Select);
        }

        async Task Select(PlaceItem place)
        {
            if (place == null)
                return;

            int TheSelectedIndex = Places.IndexOf(place);

            //Route to Location Page
            var route = $"{nameof(LocationPage)}?LocationIndex={TheSelectedIndex}";
            await Shell.Current.GoToAsync(route);

        }

    }
}
