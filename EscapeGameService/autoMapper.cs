using AutoMapper;
using EscapeGameService.Dto.EscapeGame;


namespace EscapeGameService
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<AddEscapeGameDto, Escapegame>();
            CreateMap<UpdateEscapeGameDto, Escapegame>();
            CreateMap<Escapegame,GetEscapeGameDto>();
        }
    }
}
