namespace EscapeGameService.Repository
{
    public interface ICategorieRepository : IRepository<Categorie>
    {
        Task<SubCategorie> AddSubCategorie(SubCategorie addSubcategorie);

        Task<SubCategorie> UpdateSubcategorie(SubCategorie subCategorie);

        Task<SubCategorie> DeleteSubCategorie(int id);

        IQueryable<SubCategorie> QuerySubCategory();
    }
}
