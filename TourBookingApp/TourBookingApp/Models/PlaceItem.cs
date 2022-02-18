using System;
using System.Collections.Generic;
using System.Text;

namespace TourBookingApp.Models
{
    //A Model for each place item
    internal class PlaceItem
    {
        public int Id { get; set; }
        //name of the place
        public string Name { get; set; }
        //ratings of the place
        public double Ratings { get; set; }
        //text location of the place
        
        public string Location { get; set; }
        //images of the place
        public List<string> Images { get; set; }

        public List<string>  PlaceDesc { get; set; }

        //Avg Price
        public double AvgPrice { get; set; }

        //Temperature
        public double Temperature { get; set; } 
        //Category of the place
        public TourEnums.Categories Categories { get; set; }

        //Reviews Counts
        public double Reviews { get; set; }

    }
}
