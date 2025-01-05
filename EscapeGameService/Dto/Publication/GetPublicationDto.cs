using EscapeGameService.Dto.Base;
using EscapeGameService.Dto.HasLike;
using EscapeGameService.Dto.PublicationType;

namespace EscapeGameService.Dto;
    public class GetPublicationDto :BaseDto
    {
    public int PubId { get; set; }
    public int EscapegameId { get; set; }
    public string Content { get; set; } = string.Empty;
    public int LikeNumber { get; set; }
    public bool IsDeleted { get; set; }
    public string userId { get; set; } = string.Empty;
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
    //navigation 
    public GetPublicationTypeDto? PublicationType { get; set; }
    public GetHasLikeDto? HasLike { get; set; }
}

