


namespace EscapeGameService.Repository
{
    public class CategorieRepository : Repository<Categorie>, ICategorieRepository
    {
        private readonly DataContext _dataContext;
        public CategorieRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<SubCategorie> AddSubCategorie(SubCategorie addSubcategorie)
        {
            try
            {
                SubCategorie data = _dataContext.SubCategoris.Add(addSubcategorie).Entity;
                await _dataContext.SaveChangesAsync();
                return await Task.FromResult(data);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SubCategorie> DeleteSubCategorie(int id)
        {
            try
            {
                SubCategorie subCategorieToDelete = await _dataContext.SubCategoris.FirstOrDefaultAsync(x=>x.SubCatId == id) ??
                                                                                    throw new NullReferenceException();
                _dataContext.SubCategoris.Remove(subCategorieToDelete);
                _= await _dataContext.SaveChangesAsync();

                return subCategorieToDelete;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<SubCategorie> QuerySubCategory() =>_dataContext.SubCategoris.AsNoTracking();
       

        public async  Task<SubCategorie> UpdateSubcategorie(SubCategorie subCategorie)
        {
            try
            {
                var data = _dataContext.SubCategoris.Update(subCategorie).Entity;
                await _dataContext.SaveChangesAsync();
                return await Task.FromResult(data);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
