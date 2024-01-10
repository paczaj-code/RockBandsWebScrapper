namespace ReactApp1.Server.Models
{/// <summary>
/// Model for artists list
/// </summary>
    public class ArtistsList
    {
        public string? ListTitle { get; set; }
        public List<ArtistListItem>? ArtistListItems { get; set; }
    }
}
