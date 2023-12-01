using System.Collections.ObjectModel;
using ProgressTestNew.Model;

namespace ProgressTestNew.ViewModel
{
    public class ArtworkViewModel
    {
        public ObservableCollection<ArtworkModel> ArtWorks { get; set; }

        public ArtworkViewModel()
        {
            ArtWorks = new ObservableCollection<ArtworkModel>
            {
                new ArtworkModel("Cafe Terrace at Night", "$1,920,000", "cafe.png"),
                new ArtworkModel("Peach Tree in Blossom", "$950,000", "peachtree.png")
                // Add more artworks as necessary
            };
        }
    }
}
