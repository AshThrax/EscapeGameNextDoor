using AutoMapper;
using EscapeGameService.Models.DataType;
using EscapeGameService.Repository.Publications;
using EscapeGameService.Services.Tool.Filter;

namespace EscapeGameService.Services
{
    public class PublicationService :  IPublicationService
    {
        private readonly IMapper _mapper;
        private readonly IPublicationTypeRepository _publicationTypeRepository;
        private readonly IHasLikeRepository _hasLikeRepository;
        private readonly IPublicationRepository _publicationrepository;

        public PublicationService(IMapper mapper,
                                  IPublicationTypeRepository publicationTypeRepository,
                                  IHasLikeRepository hasLikeRepository,
                                  IPublicationRepository publicationrepository)
        {
            _mapper = mapper;
            _publicationTypeRepository = publicationTypeRepository;
            _hasLikeRepository = hasLikeRepository;
            _publicationrepository = publicationrepository;
        }

        #region Publication
        public Task<ServiceResponse<GetPublicationDto>> AddPublication(AddPublicationDto addPublicationDto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Publication>> DeletePublication(int publicationId)
        {
            throw new NotImplementedException();
        }
        public Task<PaginationResponse<Publication>> GetAllPublication(PublicationFilter publication)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Publication>> Publicationbyid(int publicationId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetPublicationDto>> UpdatePublication(UpdatePublicationDto addPublicationDto)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region HasLike
        public Task<ServiceResponse<TypeLike>> AddLike(TypeLike typeLike)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<TypeLike>> DeleteLike(int TypelikeId)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<TypeLike>> GetLike()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region TypeLike
        public Task<ServiceResponse<TypeLike>> AddTypelike(TypeLike typeLike)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<TypeLike>> DeleteTypeLike(int TypelikeId)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<List<TypeLike>>> GetAllTypeLike()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TypeLike>> UpdateTypelike()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region PublicationType
        public Task<ServiceResponse<PublicationType>> AddPublicationType()
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<List<PublicationType>>> GetAllPublicationType()
        {
            throw new NotImplementedException();
        }

        #endregion





        
    }
}
