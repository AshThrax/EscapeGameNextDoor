using EscapeGameService.Dto.Categorie;
using EscapeGameService.Dto.SubCategory;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services.Categorie
{
    public interface ICategoryService
    {
        Task<ServiceResponse<GetCategoryDto>> AddCategories(AddCategoryDto addCategory);
        Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategory updateCategory);
        Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id);
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategory();
        Task<ServiceResponse<GetCategoryDto>> DeleteCategory(int id);

        Task<ServiceResponse<GetCategoryDto>> AddSubCategories(AddSubCategoryDto addCategory);
        Task<ServiceResponse<GetCategoryDto>> UpdateSubCategory(UpdateSubCategoryDto updateCategory);
        Task<ServiceResponse<GetCategoryDto>> GetSubCategoryById(int id);
        Task<ServiceResponse<List<GetCategoryDto>>> GetAllSubCategoryByCategoryParent(int  CatId);
        Task<ServiceResponse<GetCategoryDto>> DeleteSubCategory(int subCatid);
    }
}
