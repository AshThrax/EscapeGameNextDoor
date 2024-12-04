using Microsoft.Extensions.Logging;

namespace EscapeGameService.Models
{
    public class Escapegame
    {
        public int ESGId { get; set; }
        public string ESGNom { get; set; } = string.Empty;
        public string ESGCreator { get; set; } = string.Empty;
        public string ESGTitle { get; set; } = string.Empty;
        public string ESGContent { get; set; } = string.Empty;
        public string ESGImgResources { get; set; } = string.Empty;
        public string ESGWebsite { get; set; } = string.Empty;
        public string ESGPhoneNumber { get; set; } = string.Empty;
        public bool ESG_IsDeleting { get; set; }
        public bool ESG_IsForChildren { get; set; }
        public int ESG_Price_Id { get; set; }
        public int ESG_DILE_Id { get; set; }
        public DateTime ESG_CreationDate { get; set; }
        public DateTime ESG_UpdateTime { get; set; }

        // Navigation 
        public DifficultyLevel? DifficultyLevel { get; set; }
        public Price? Price { get; set; }
        public List<HasBeenDone>? HasBeenDones { get; set; }
        public List<Event>? Events { get; set; }
        public List<Categorie>? Categories { get; set; }
    }
}
