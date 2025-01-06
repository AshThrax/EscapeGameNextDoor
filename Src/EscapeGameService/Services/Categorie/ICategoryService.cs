using EscapeGameService.Dto.Categorie;
using EscapeGameService.Dto.SubCategory;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services
{
    public interface ICategoryService
    {
        Task<ServiceResponse<GetCategoryDto>> AddCategories(AddCategoryDto addCategory);
        Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategory updateCategory);
        Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id);
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategory();
        Task<ServiceResponse<GetCategoryDto>> DeleteCategory(int id);

        Task<ServiceResponse<GetSubCategoryDto>> AddSubCategories(AddSubCategoryDto addCategory);
        Task<ServiceResponse<GetSubCategoryDto>> UpdateSubCategory(UpdateSubCategoryDto updateCategory);
        Task<ServiceResponse<GetSubCategoryDto>> GetSubCategoryById(int id);
        Task<ServiceResponse<List<GetSubCategoryDto>>> GetAllSubCategoryByCategoryParent(int  CatId);
        Task<ServiceResponse<GetSubCategoryDto>> DeleteSubCategory(int subCatid);
    }
}
