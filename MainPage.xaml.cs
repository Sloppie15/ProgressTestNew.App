using ProgressTestNew.ViewModel;
using System.Collections.ObjectModel;

namespace ProgressTestNew;

// MainPage.xaml.cs
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ArtViewModel();
    }
}

// ArtViewModel.cs
public class ArtViewModel
{
    public ObservableCollection<ArtWork> ArtWorks { get; set; }

    public ArtViewModel()
    {
        ArtWorks = new ObservableCollection<ArtWork>
        {
            new ArtWork
            {
                Title = "Cafe Terrace at Night",
                Price = "$1,920,000",
                ImgUrl = "caffee.jpg"
                // ... other properties
            },
            new ArtWork
            {
                Title = "Peach Tree in Blossom",
                Price = "$950,000",
                 ImgUrl = "peachtree.jpg"
                // ... other properties
            },

              new ArtWork
            {
                Title = "Monalisa",
                Price = "$1",
                 ImgUrl = "monalisa.jpg"
                // ... other properties
            },

                new ArtWork
            {
                Title = "Doraemon",
                Price = "$20",
                 ImgUrl = "dora.jpg"
                // ... other properties
            },

            // ... other artworks
        };
    }
}

// ArtWork.cs
public class ArtWork
{
    public string Title { get; set; }
    public string Price { get; set; }

     public string ImgUrl { get; set; }
    // ... other properties like Image, Description, etc.
}



