using AutoMapper;
namespace EscapeGameService.Services
{
    public class PublicationService : Service<Publication, GetPublicationDto, AddPublicationDto, UpdatePublicationDto>, IPublicationService
    {
        public PublicationService(IRepository<Publication> repository, IMapper map) : base(repository, map)
        {
        }
    }
}
