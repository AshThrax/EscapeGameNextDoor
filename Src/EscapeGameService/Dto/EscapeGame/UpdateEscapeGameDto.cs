using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.EscapeGame
{
    public class UpdateEscapeGameDto : UpdateDto
    {
        public int ESGId { get; set; }
        public string ESGNom { get; set; } = string.Empty;
        public string ESGCreator { get; set; } = string.Empty;
        public string ESGTitle { get; set; } = string.Empty;
        public string ESGContent { get; set; } = string.Empty;
        public string ESGImgResources { get; set; } = string.Empty;
        public string ESGWebsite { get; set; } = string.Empty;
        public string ESGPhoneNumber { get; set; } = string.Empty;
        public bool ESG_IsForChildren { get; set; }
        public int ESG_Price_Id { get; set; }
        public int ESG_DILE_Id { get; set; }

    }
}
