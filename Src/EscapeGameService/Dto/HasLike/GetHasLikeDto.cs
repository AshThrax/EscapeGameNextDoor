using EscapeGameService.Dto.Base;
using EscapeGameService.Dto.TypeLike;

namespace EscapeGameService.Dto.HasLike
{
    public class GetHasLikeDto : BaseDto
    {
        public int Id { get; set; }
        public int PubId { get; set; }
        public string UserId { get; set; } = string.Empty;

        public GetTypeLikeDto? TypeLIke { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
