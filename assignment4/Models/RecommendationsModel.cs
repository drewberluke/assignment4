using System;
namespace assignment4.Models
{
    public class RecommendationsModel
    {
        //collects the record number when the records are initialized
        public RecommendationsModel(int num)
        {
            RecNo = num;
        }

        //attributes, default values where required
        public int RecNo { get; }
        public string RecName { get; set; }
        public string RecFav { get; set; } = "It's all tasty!";
        public string RecAddress { get; set; }
        public string RecPhone { get; set; } = "None";
        public string RecWeb { get; set; } = "<a>Website Coming Soon</a>";
        public string RecPhoto { get; set; }

        //my recomendations
        public static RecommendationsModel[] GetRecs()
        {
            RecommendationsModel r1 = new RecommendationsModel(1)
            {
                RecName = "Five Guys Burgers and Fries",
                RecFav = "Bacon Cheeseburger",
                RecAddress = "1051 S 750 E, Orem, UT 84097",
                RecPhone = "(801) 765-7556",
                RecWeb = "<a class='btn btn-outline-secondary' href='https://fiveguys.com' target=_blank>Website</a>",
                RecPhoto = "5guys.jpeg"
            };

            RecommendationsModel r2 = new RecommendationsModel(2)
            {
                RecName = "Cheesecake Factory",
                RecFav = "Oreo Deluxe Cheesecake",
                RecAddress = "6223 S State St, Murray, UT 84107",
                RecPhone = "(801) 266-9100",
                //RecWeb = "<a class='btn btn-outline-secondary' href='https://thecheesecakefactory.com' target=_blank>Website</a>",
                RecPhoto = "cheesecake.jpg"
            };

            RecommendationsModel r3 = new RecommendationsModel(3)
            {
                RecName = "Kohinoor",
                RecFav = "Chicken Tikka  Masala",
                RecAddress = "75 State St, Orem, UT 84058",
                //RecPhone = "(801) 226-6666",
                RecWeb = "<a class='btn btn-outline-secondary' href='https://kohinoorut.com' target=_blank>Website</a>",
                RecPhoto = "indian.jpg"
            };

            RecommendationsModel r4 = new RecommendationsModel(4)
            {
                RecName = "Strap Tank Brewery",
                //RecFav = "Steak Nachos",
                RecAddress = "596 S 1750 W, Springville, UT 84663",
                RecPhone = "(385) 325-0262",
                RecWeb = "<a class='btn btn-outline-secondary' href='https://straptankbrewery.com' target=_blank>Website</a>",
                RecPhoto = "straptank.jpeg"
            };

            RecommendationsModel r5 = new RecommendationsModel(5)
            {
                RecName = "Chick-fil-A",
                RecFav = "Classic Chicken Sandwich",
                RecAddress = "484 Bulldog Ln, Provo, UT 84604",
                RecPhone = "(801) 374-2697",
                RecWeb = "<a class='btn btn-outline-secondary' href='https://chick-fil-a.com' target=_blank>Website</a>",
                RecPhoto = "chick.jpg"
            };

            return new RecommendationsModel[] { r1, r2, r3, r4, r5 };
        }
    }
}
