using EscapeGameService.Dto.EscapeGame;
using EscapeGameService.Services;

namespace EscapeGameService.Services.Escapesgame
{
    public interface IEscapeGameServices : IService<Escapegame, GetEscapeGameDto, AddEscapeGameDto, UpdateEscapeGameDto>
    {
    }
}
