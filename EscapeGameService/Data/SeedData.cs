namespace EscapeGameService.Data
{
    public static class SeedData
    {
       

        public static async Task SeedAsync(DataContext dataContext)
        {
            if (!dataContext.DayOftheWeeks.Any())
            {
                await dataContext.DayOftheWeeks.AddRangeAsync(GetDaysList());
            }


            if (!dataContext.Prices.Any())
            {

            }

            if (!dataContext.PublicationTypes.Any())
            {

            }
            if (!dataContext.TypeLike.Any())
            {

            }
            if (!dataContext.DifficultyLevels.Any())
            {

            }

            if (!dataContext.ActivityPlacesTypes.Any())
            {

            }

            if (!dataContext.Categories.Any())
            {

            }

            if (!dataContext.SubCategoris.Any())
            {

            }

            if (!dataContext.ActivityPlaces.Any())
            {

            }

            if (!dataContext.Escapegames.Any())
            {
                
            }
            _ = await dataContext.SaveChangesAsync();
        }
        /// <summary>
        /// add a list of days to the data base
        /// </summary>
        /// <returns></returns>
        public static List<DayOftheWeek> GetDaysList()
        {
            return new List<DayOftheWeek> 
            {
                new DayOftheWeek{
                    DowId = 1,
                    DowName="Monday"
                },
                new DayOftheWeek{
                    DowId = 2,
                    DowName="Thursday"
                },
                new DayOftheWeek {
                    DowId = 3,
                    DowName="Woensday"},
                new DayOftheWeek{
                    
                    DowId = 4,
                    DowName="Tuesday"
                },
                new DayOftheWeek{
                     DowId = 5,
                    DowName="Friday"
                },
                new DayOftheWeek {
                    DowId = 6,
                    DowName="Saturday"},
                new DayOftheWeek {
                    DowId = 7,
      
                    DowName="Sunday"
                },
            };
        }
        /// <summary>
        /// add price indicator
        /// </summary>
        /// <returns></returns>
        public static List<Price> GePriceList() {
            return new List<Price>
            {
                new Price 
                {
                    IndicePrice = 1,
                },
                new Price { 
                    IndicePrice = 2,
                },
                new Price {
                    IndicePrice = 3,
                },
                new Price {
                   IndicePrice= 4,
                },
                new Price { 
                   IndicePrice= 5,
                }
            };
        }
        /// <summary>
        /// difficulty level list 
        /// </summary>
        /// <returns></returns>
        public static List<DifficultyLevel> GetDifficultyLevels()
        {
            return new List<DifficultyLevel> { 
                   
                new DifficultyLevel{
                    DileId = 1,
                    DileLevel="Beginner",
                },
                new DifficultyLevel{
                    DileId=2,
                    DileLevel="Medium"
                },
                new DifficultyLevel{
                    DileId=3,
                    DileLevel="Advance"
                },
                new DifficultyLevel
                {
                    DileId=4,
                    DileLevel="Expert"
                }
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<PublicationType> GetPublicationTypes() {
            return new List<PublicationType>
            {
                new PublicationType
                {
                    PublicationTypeId = 1,
                    PublicationTypeName="Post"
                },
                 new PublicationType
                {
                    PublicationTypeId = 2,
                    PublicationTypeName="Video"
                },
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<TypeLike> GetTypesLike()
        {
            return new List<TypeLike> {
                new TypeLike
                {
                    TypeLikeId = 1,
                    TypeLikeName="Like"
                },
                new TypeLike
                {
                    TypeLikeId = 2,
                    TypeLikeName="Love"
                },
                new TypeLike
                {
                    TypeLikeId = 3,
                    TypeLikeName="hahah"
                }
            };
        }
        /// <summary>
        /// get a list
        /// </summary>
        /// <returns></returns>
        public static List<ActivityPlacesType> GetActivityPlacesTypes() 
        {
            return new List<ActivityPlacesType>
            {
                new ActivityPlacesType {
                    Name="Bar"
                },
                new ActivityPlacesType{
                    Name="Restaurant"
                },
                new ActivityPlacesType{
                    Name="Touristic"
                },
                new ActivityPlacesType{
                    Name="Atttraction"
                }
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Categorie> GetCategories() 
        {
            return new List<Categorie>
            {
                new Categorie{
                    CatName="Réalité Virutel"
                },
                new Categorie
                {
                    CatName="Cyberpunk"
                },
                new Categorie
                {
                    CatName="Vanilla"
                },
                new Categorie
                {
                    CatName="Egypte"
                },
            };
        }
    }
}
