namespace EscapeGameService.Data
{
    public static class SeedData
    {
       

        public static async Task SeedAsync(DataContext dataContext)
        {
            if (!dataContext.DayOftheWeeks.Any())
            {
                await dataContext.DayOftheWeeks.AddRangeAsync(GetDaysList());
                _ = await dataContext.SaveChangesAsync(); 
            }


            if (!dataContext.Prices.Any())
            {
                await dataContext.Prices.AddRangeAsync(GetPriceList());
                _ = await dataContext.SaveChangesAsync();
            }

            if (!dataContext.PublicationTypes.Any())
            {
                await dataContext.PublicationTypes.AddRangeAsync(GetPublicationTypes());
                _ = await dataContext.SaveChangesAsync();
            }
            if (!dataContext.TypeLike.Any())
            {
                await dataContext.TypeLike.AddRangeAsync(GetTypesLike());
                _ = await dataContext.SaveChangesAsync();
            }
            if (!dataContext.DifficultyLevels.Any())
            {
                await dataContext.DifficultyLevels.AddRangeAsync(GetDifficultyLevels());
                _ = await dataContext.SaveChangesAsync();
            }

            if (!dataContext.ActivityPlacesTypes.Any())
            {
                await dataContext.ActivityPlacesTypes.AddRangeAsync(GetActivityPlacesTypes());
                _ = await dataContext.SaveChangesAsync();
            }

            if (!dataContext.Categories.Any())
            {
                await dataContext.Categories.AddRangeAsync(GetCategories());
                _ = await dataContext.SaveChangesAsync();
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
                  
                    DowName="Monday"
                },
                new DayOftheWeek{
                
                    DowName="Thursday"
                },
                new DayOftheWeek {
                   
                    DowName="Woensday"},
                new DayOftheWeek{
                    
                    
                    DowName="Tuesday"
                },
                new DayOftheWeek{
                    
                    DowName="Friday"
                },
                new DayOftheWeek {
                 
                    DowName="Saturday"},
                new DayOftheWeek {
                  
      
                    DowName="Sunday"
                },
            };
        }
        /// <summary>
        /// add price indicator
        /// </summary>
        /// <returns></returns>
        public static List<Price> GetPriceList() {
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
                   
                    DileLevel="Beginner",
                },
                new DifficultyLevel{
                  
                    DileLevel="Medium"
                },
                new DifficultyLevel{
                  
                    DileLevel="Advance"
                },
                new DifficultyLevel
                {
                
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
                  
                    PublicationTypeName="Post"
                },
                 new PublicationType
                {
                  
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
                   
                    TypeLikeName="Like"
                },
                new TypeLike
                {
                 
                    TypeLikeName="Love"
                },
                new TypeLike
                {
                  
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
