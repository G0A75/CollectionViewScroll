namespace CollectionViewScroll;

public class ThingGroup(string name, List<Thing> things) : List<Thing>(things)
{
    public string Name { get; set; } = name;
}