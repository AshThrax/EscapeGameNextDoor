using AutoMapper;
using EscapeGameService.Dto.Categorie;
using EscapeGameService.Dto.SubCategory;
using EscapeGameService.Models.DataType;

namespace EscapeGameService.Services
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
        /// <summary>
        /// add a new categorie entity
        /// </summary>
        /// <param name="addCategory"></param>
        /// <returns></returns>
        public async Task<ServiceResponse<GetCategoryDto>> AddCategories(AddCategoryDto addCategory)
        {
            try
            {
                Categorie addEntityCategory = _mapper.Map<Categorie>(addCategory);
                addEntityCategory= await _categoryrepository.CreateAsync(addEntityCategory);

                return await SuccessManager.SuccessResponse(_mapper.Map<GetCategoryDto>(addEntityCategory));

            }
            catch (Exception ex)
            {
                return await ErrorManager.ManageError<GetCategoryDto>(ex,null);
            }
        }

        public async Task<ServiceResponse<GetSubCategoryDto>> AddSubCategories(AddSubCategoryDto addCategory)
        {

            try
            {
                SubCategorie addEntityCategory = _mapper.Map<SubCategorie>(addCategory);
                addEntityCategory = await _subCategorieRepository.CreateAsync(addEntityCategory);

                return await SuccessManager.SuccessResponse(_mapper.Map<GetSubCategoryDto>(addEntityCategory));
            }
            catch (Exception ex)
            {
                return await ErrorManager.ManageError<GetSubCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetCategoryDto>> DeleteCategory(int id)
        {
            try
            {
                if (id > 0)
                {
                    throw new ArgumentException("the ide pâssed as aparamreter isn't valid ");
                }
                
                Categorie categorieToRemove = await _categoryrepository.GetById(id);
                
                if (categorieToRemove != null)
                {
                    throw new NullReferenceException("no reference of the object");
                }
                
                categorieToRemove = await _categoryrepository.DeleteAsync(id);  
                return await SuccessManager.SuccessResponse(_mapper.Map<GetCategoryDto>(categorieToRemove));
            }
            catch (Exception ex)
            {
                return await ErrorManager.ManageError<GetCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetSubCategoryDto>> DeleteSubCategory(int subCatid)
        {
            try
            {
                if (subCatid > 0)
                {
                    throw new ArgumentException("the ide pâssed as aparamreter isn't valid ");
                }
                
                SubCategorie subCategorieToRemove = await _subCategorieRepository.GetById(subCatid);
                
                if (subCategorieToRemove != null)
                {
                    throw new NullReferenceException("no reference of the object");
                }

                subCategorieToRemove = await _subCategorieRepository.DeleteAsync(subCatid);
                return await SuccessManager.SuccessResponse(_mapper.Map<GetSubCategoryDto>(subCategorieToRemove));
            }
            catch (Exception ex)
            {
                return await ErrorManager.ManageError<GetSubCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<List<GetCategoryDto>>> GetAllCategory()
        {
            try
            {
               
                return await SuccessManager.SuccessResponse(_mapper.Map<List<GetCategoryDto>>(await _categoryrepository.GetAllAsync()));
            }
            catch (Exception ex)
            {

                return await ErrorManager.ManageError<List<GetCategoryDto>>(ex, null);
            }
        }

        public async Task<ServiceResponse<List<GetSubCategoryDto>>> GetAllSubCategoryByCategoryParent(int CatId)
        {
            try
            {
                return await SuccessManager.SuccessResponse(_mapper.Map<List<GetSubCategoryDto>>(await _subCategorieRepository.Query().Where(xc =>xc.CatId==CatId).ToListAsync()));
            }
            catch (Exception ex)
            {
                return await ErrorManager.ManageError<List<GetSubCategoryDto>>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetCategoryDto>> GetCategoryById(int id)
        {
            try
            {
                return await SuccessManager.SuccessResponse(_mapper.Map<GetCategoryDto>(await _categoryrepository.GetById(id)));
            }
            catch (Exception ex)
            {

                return await ErrorManager.ManageError<GetCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetSubCategoryDto>> GetSubCategoryById(int id)
        {
            try
            {
                return await SuccessManager.SuccessResponse(_mapper.Map<GetSubCategoryDto>(await _subCategorieRepository.GetById(id)));
            }
            catch (Exception ex)
            {

                return await ErrorManager.ManageError<GetSubCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetCategoryDto>> UpdateCategory(UpdateCategory updateCategory)
        {
            try
            {
                if (updateCategory == null)
                {
                    throw new ArgumentException("the object cannot be process");
                }

                Categorie categorietoUpdate = await _categoryrepository.GetById(updateCategory.CatId);

                //make the modification required 
                categorietoUpdate.CatName=updateCategory.CatName;
                categorietoUpdate= await _categoryrepository.UpdateAsync(categorietoUpdate);

                return await SuccessManager.SuccessResponse(_mapper.Map<GetCategoryDto>(categorietoUpdate));
            }
            catch (Exception ex)
            {

                return await ErrorManager.ManageError<GetCategoryDto>(ex, null);
            }
        }

        public async Task<ServiceResponse<GetSubCategoryDto>> UpdateSubCategory(UpdateSubCategoryDto updateCategory)
        {
            try
            {
                if (updateCategory == null)
                {
                    throw new ArgumentException("the object Cannot be process");
                }
                
                SubCategorie subCategorieToUpdate = await _subCategorieRepository.GetById(updateCategory.SubCatId);
                //make the modification required
                subCategorieToUpdate.SubCatName =updateCategory.SubCatName;
                subCategorieToUpdate.CatId = updateCategory.CatId;
                subCategorieToUpdate = await _subCategorieRepository.UpdateAsync(subCategorieToUpdate);
                return await SuccessManager.SuccessResponse(_mapper.Map<GetSubCategoryDto>(subCategorieToUpdate));
            }
            catch (Exception ex)
            {

                return await ErrorManager.ManageError<GetSubCategoryDto>(ex, null);
  
            }
        }
    }
}
