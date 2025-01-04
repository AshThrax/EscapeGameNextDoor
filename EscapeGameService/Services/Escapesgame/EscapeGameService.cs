using AutoMapper;
using EscapeGameService.Dto.EscapeGame;
using EscapeGameService.Repository.EscapeGame;

namespace EscapeGameService.Services.Escapesgame
{
    public class EscapeGameServices : Service<Escapegame, GetEscapeGameDto, AddEscapeGameDto, UpdateEscapeGameDto>,IEscapeGameServices
    {
        private readonly IEscapeRepository _repository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IMapper _map;
        public EscapeGameServices(IEscapeRepository repository, ICloudinaryService cloudinaryService, IMapper map) : base(repository,map)
        {
            _repository = repository;
            _cloudinaryService = cloudinaryService;
            _map = map;
        }
    }
}
