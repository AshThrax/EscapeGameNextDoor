using EscapeGameService.Dto.Base;

namespace EscapeGameService.Dto.DifficultyLevel
{
    public class AddDifficultyLevelDto: AddDto
    {
        public string DowName { get; set; } = string.Empty;

    }
}
