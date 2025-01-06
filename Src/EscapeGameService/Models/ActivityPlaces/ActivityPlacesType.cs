namespace EscapeGameService.Models;
public class ActivityPlacesType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    //navigation
    public List<ActivityPlacesType>? ActivityPlaces { get; set; }
}

