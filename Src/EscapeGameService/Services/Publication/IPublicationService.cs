

using EscapeGameService.Models.DataType;
using EscapeGameService.Services.Tool.Filter;

namespace EscapeGameService.Services
{
    public interface IPublicationService 
    {
        #region Publication
        Task<ServiceResponse<GetPublicationDto>> AddPublication(AddPublicationDto addPublicationDto);
        Task<ServiceResponse<GetPublicationDto>> UpdatePublication(UpdatePublicationDto addPublicationDto);
        Task<ServiceResponse<Publication>> DeletePublication(int publicationId);
        Task<PaginationResponse<Publication>> GetAllPublication(PublicationFilter publication);
        Task<ServiceResponse<Publication>> Publicationbyid(int publicationId);
        #endregion

        #region HasTypeLike 
        Task<ServiceResponse<TypeLike>> AddTypelike(TypeLike typeLike);
        Task<ServiceResponse<TypeLike>> UpdateTypelike();
        Task<ServiceResponse<TypeLike>> DeleteTypeLike(int TypelikeId);
        Task<ServiceResponse<List<TypeLike>>> GetAllTypeLike();
        #endregion

        #region HasLike
        Task<ServiceResponse<TypeLike>> AddLike(TypeLike typeLike);
        Task<ServiceResponse<TypeLike>> GetLike();
        Task<ServiceResponse<TypeLike>> DeleteLike(int TypelikeId);
        #endregion

        #region PublicationType
        Task<ServiceResponse<List<PublicationType>>> GetAllPublicationType();
        Task<ServiceResponse<PublicationType>> AddPublicationType();
        #endregion
    }
}
