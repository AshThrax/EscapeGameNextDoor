using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.DifficultyLevel
{
    public class GetDifficultyLevelDto:BaseDto
    {
        public int DowId { get; set; }
        public string DowName { get; set; } = string.Empty;

    }
}
