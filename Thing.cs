namespace CollectionViewScroll;

public class Thing(string name, string description, int group)
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public int Group { get; set; } = group;
}