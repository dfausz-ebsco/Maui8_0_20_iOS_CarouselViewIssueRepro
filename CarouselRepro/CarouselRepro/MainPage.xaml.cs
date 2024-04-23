using System.Collections.ObjectModel;

namespace CarouselRepro
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Foo> FooItemPair { get; set; } = new ObservableCollection<Foo>
        {
            new Foo { ImagePath = "red_mm.png" },
            new Foo { ImagePath = "yellow_mm.png" }
        };

        public ObservableCollection<Foo> FooItemTrio { get; set; } = new ObservableCollection<Foo>
        {
            new Foo { ImagePath = "red_mm.png" },
            new Foo { ImagePath = "yellow_mm.png" },
            new Foo { ImagePath = "blue_mm.png"}
        };

        public ObservableCollection<Foo> FooItemQuad { get; set; } = new ObservableCollection<Foo>
        {
            new Foo { ImagePath = "red_mm.png" },
            new Foo { ImagePath = "yellow_mm.png" },
            new Foo { ImagePath = "blue_mm.png"},
            new Foo { ImagePath = "orange_mm.png"}
        };

        public MainPage()
        {
            InitializeComponent();
        }
    }

}
