using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTestNew.Model
{


    // ArtWork.cs
    public class ArtworkModel
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string ImgUrl { get; set; }

        // Constructor for convenience
        public ArtworkModel(string title, string price, string imgUrl)
        {
            Title = title;
            Price = price;
            ImgUrl = imgUrl;
        }
    }

}
