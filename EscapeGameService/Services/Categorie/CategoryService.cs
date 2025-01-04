using AutoMapper;
using EscapeGameService.Dto.Categorie;
using EscapeGameService.Dto.SubCategory;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services.Categorie
{
    public class CategoryService : ICategoryService
    {

        private readonly IMapper _mapper;
        private readonly ICategorieRepository _categoryrepository;
        private readonly ISubCategorieRepository _subCategorieRepository;
        public CategoryService(ICategorieRepository categorieRepository,
                               IMapper mapper,
                               ISubCategorieRepository subCategorieRepository)
        {
            _mapper = mapper;
            _categoryrepository = categorieRepository;
            _subCategorieRepository = subCategorieRepository;
        }

        public Task<ServiceResponse<GetCategoryDto>> AddCategories(AddCategoryDto addCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> AddSubCategories(AddSubCategoryDto addCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> DeleteSubCategory(int subCatid)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetCategoryDto>>> GetAllSubCategoryByCategoryParent(int CatId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> GetSubCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategory updateCategory)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCategoryDto>> UpdateSubCategory(UpdateSubCategoryDto updateCategory)
        {
            throw new NotImplementedException();
        }
    }
}
