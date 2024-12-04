namespace EscapeGameService.Repository.Admin
{
    public interface IAdminRepository
    {
        #region Difficulty
        /// <summary>
        /// récupère un type se lieux d'activité basé sur son id 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<DifficultyLevel> UpdateDifficulty(DifficultyLevel difficultyLevel);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="difficultyLevel"></param>
        /// <returns></returns>
        Task<DifficultyLevel> CreateDifficulty(DifficultyLevel difficultyLevel);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="difficultyLevel"></param>
        /// <returns></returns>
        Task<DifficultyLevel>DeleteDifficulty(int levelId);
        #endregion

        #region Price
        /// <summary>
        /// update a Difficulty
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<DifficultyLevel> UpdatePriceIndicator(Price priceToUpdate);
        /// <summary>
        /// create a new Difficulty level
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<DifficultyLevel> CreatePriceIndicator(Price addLevel);
        /// <summary>
        /// delete a difficultylevel from the database 
        /// </summary>
        /// <param name="delelteLevel"></param>
        /// <returns></returns>
        Task<DifficultyLevel> DeletePriceIndicator(int delelteLevel);
        #endregion

        #region Categorie
        /// <summary>
        /// update a categorie
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<Categorie> UpdateCategorie(Categorie updateCategorie);
        /// <summary>
        /// create a new categorie
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<Categorie> CreateCategorie(Categorie addCategorie);
        /// <summary>
        /// delete a categorie
        /// </summary>
        /// <param name="delelteLevel"></param>
        /// <returns></returns>
        Task<Categorie> DeleteCategorie(int categorieId);
        #endregion

        #region SubCategorie
        /// <summary>
        /// update a categorie
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<Categorie> UpdateSubCategorie(SubCategorieRepository updateSubCategorie);
        /// <summary>
        /// create a new categorie
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<Categorie> CreateSubCategorie(SubCategorieRepository addSubCategorie);
        /// <summary>
        /// delete a categorie
        /// </summary>
        /// <param name="delelteLevel"></param>
        /// <returns></returns>
        Task<Categorie> DeleteSubCategorie(int subCategorieId);
        #endregion

        #region HasLikeType
        /// <summary>
        /// update a type of like 
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<TypeLike> UpdateTypeLike(Price priceToUpdate);
        /// <summary>
        /// create a new typeof like
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<TypeLike> CreateTypeLike(Price addLevel);
        /// <summary>
        /// delete a type of like 
        /// </summary>
        /// <param name="delelteLevel"></param>
        /// <returns></returns>
        Task<TypeLike> DeleteTypeLike(int delelteLevel);
        #endregion

        #region publicationType
        /// <summary>
        /// update a type of Publication Type
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<PublicationType> UpdatePublicationType(PublicationType pubType);
        /// <summary>
        /// create a new Type of a Publication Type
        /// </summary>
        /// <param name="escapesGameId"></param>
        /// <returns></returns>
        Task<PublicationType> CreatePublicationType(PublicationType pubType);
        /// <summary>
        /// delete a Publication Type
        /// </summary>
        /// <param name="delelteLevel"></param>
        /// <returns></returns>
        Task<PublicationType> DeletePublicationType(int publicationTypeId);
        #endregion
    }
}
