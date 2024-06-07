namespace CollectionViewScroll;

public partial class MainPage : ContentPage
{
    public List<ThingGroup> ThingGroups { get; set; } = new List<ThingGroup>
        {
            new ThingGroup("Group 1", [
                new Thing("Item 1A", "Description for item 1A", 1),
                new Thing("Item 1B", "Description for item 1B", 1),
                new Thing("Item 1C", "Description for item 1C", 1),
                new Thing("Item 1D", "Description for item 1D", 1),
                new Thing("Item 1E", "Description for item 1E", 1),
                new Thing("Item 1F", "Description for item 1F", 1),
                new Thing("Item 1G", "Description for item 1G", 1),
                new Thing("Item 1H", "Description for item 1H", 1),
                new Thing("Item 1I", "Description for item 1I", 1),
                new Thing("Item 1J", "Description for item 1J", 1),
                new Thing("Item 1K", "Description for item 1K", 1),
                new Thing("Item 1L", "Description for item 1L", 1),
                new Thing("Item 1M", "Description for item 1M", 1),
                new Thing("Item 1N", "Description for item 1N", 1),
                new Thing("Item 1O", "Description for item 1O", 1),
                new Thing("Item 1P", "Description for item 1P", 1),
                new Thing("Item 1Q", "Description for item 1Q", 1),
                new Thing("Item 1R", "Description for item 1R", 1),
                new Thing("Item 1S", "Description for item 1S", 1),
                new Thing("Item 1T", "Description for item 1T", 1)
            ]),
            new ThingGroup("Group 2", [
                new Thing("Item 2A", "Description for item 2A", 2),
                new Thing("Item 2B", "Description for item 2B", 2),
                new Thing("Item 2C", "Description for item 2C", 2),
                new Thing("Item 2D", "Description for item 2D", 2),
                new Thing("Item 2E", "Description for item 2E", 2),
                new Thing("Item 2F", "Description for item 2F", 2),
                new Thing("Item 2G", "Description for item 2G", 2),
                new Thing("Item 2H", "Description for item 2H", 2),
                new Thing("Item 2I", "Description for item 2I", 2),
                new Thing("Item 2J", "Description for item 2J", 2),
                new Thing("Item 2K", "Description for item 2K", 2),
                new Thing("Item 2L", "Description for item 2L", 2),
                new Thing("Item 2M", "Description for item 2M", 2),
                new Thing("Item 2N", "Description for item 2N", 2),
                new Thing("Item 2O", "Description for item 2O", 2),
                new Thing("Item 2P", "Description for item 2P", 2),
                new Thing("Item 2Q", "Description for item 2Q", 2),
                new Thing("Item 2R", "Description for item 2R", 2),
                new Thing("Item 2S", "Description for item 2S", 2),
                new Thing("Item 2T", "Description for item 2T", 2)
            ]), 
            new ThingGroup("Group 3", [
                new Thing("Item 3A", "Description for item 3A", 3),
                new Thing("Item 3B", "Description for item 3B", 3),
                new Thing("Item 3C", "Description for item 3C", 3),
                new Thing("Item 3D", "Description for item 3D", 3),
                new Thing("Item 3E", "Description for item 3E", 3),
                new Thing("Item 3F", "Description for item 3F", 3),
                new Thing("Item 3G", "Description for item 3G", 3),
                new Thing("Item 3H", "Description for item 3H", 3),
                new Thing("Item 3I", "Description for item 3I", 3),
                new Thing("Item 3J", "Description for item 3J", 3),
                new Thing("Item 3K", "Description for item 3K", 3),
                new Thing("Item 3L", "Description for item 3L", 3),
                new Thing("Item 3M", "Description for item 3M", 3),
                new Thing("Item 3N", "Description for item 3N", 3),
                new Thing("Item 3O", "Description for item 3O", 3),
                new Thing("Item 3P", "Description for item 3P", 3),
                new Thing("Item 3Q", "Description for item 3Q", 3),
                new Thing("Item 3R", "Description for item 3R", 3),
                new Thing("Item 3S", "Description for item 3S", 3),
                new Thing("Item 3T", "Description for item 3T", 3)
            ])
        };
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
        
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        var cv = ThingView;
        var button = (Button)sender!;

        switch (button.Text)
        {
            case "1":
                cv.ScrollTo(0,0);
                break;
            case "2":
                cv.ScrollTo(0,1);
                break;
            case "3":
                cv.ScrollTo(0,2);
                break;
        }
    }
}