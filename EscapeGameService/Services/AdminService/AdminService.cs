using EscapeGameService.Repository.Publications;

namespace EscapeGameService.Services
{
    public class AdminService
    {
       private readonly ICategorieRepository _categorieRepository;
       private readonly ISubCategorieRepository _subCategorieRepository;
       private readonly IPublicationTypeRepository _publicationTypeRepository;
       private readonly IHasLikeRepository _hasLikeRepository;
        private readonly IActivityPlaceRepository _activityPlaceRepository; 
       public AdminService(ICategorieRepository categorieRepository,
                           ISubCategorieRepository subCategorieRepository, 
                           IPublicationTypeRepository publicationTypeRepository, 
                           IHasLikeRepository hasLikeRepository,
                           IActivityPlaceRepository activityPlaceRepository)
        {
            _categorieRepository = categorieRepository;
            _subCategorieRepository = subCategorieRepository;
            _publicationTypeRepository = publicationTypeRepository;
            _hasLikeRepository = hasLikeRepository;
            _activityPlaceRepository = activityPlaceRepository; 
        }
    }
}
