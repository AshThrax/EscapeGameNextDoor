namespace EscapeGameService.Data
{
    public class DataContext :DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        { 
        }

        public DbSet<Escapegame> Escapegames { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<SubCategorie> SubCategoris { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationType> PublicationTypes { get; set; }
        public DbSet<TypeLike> TypeLike { get; set; }
        public DbSet<HasLike> HasLike { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<HasBeenDone> HasBeenDones { get; set; }
        public DbSet<SessionGame> SessionGames { get; set; }
        public DbSet<DayOftheWeek> DayOftheWeeks { get; set; }
        public DbSet<Favoris> Favoris { get; set; }
        public DbSet<SessionReserved> SessionReserveds { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<ActivityPlaces> ActivityPlaces { get; set; }
        public DbSet<ActivityPlacesType> ActivityPlacesTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //entity------------
            _= modelBuilder.Entity<Escapegame>()
                          .HasKey(x=>x.ESGId);

            _ = modelBuilder.Entity<DayOftheWeek>()
                            .HasKey(x=>x.DowId);
            //Difficulty--------
            _ = modelBuilder.Entity<DifficultyLevel>()
                            .HasKey(x=> x.DileId);

            _ = modelBuilder.Entity<Escapegame>()
                            .HasOne(x => x.DifficultyLevel)
                            .WithMany()
                            .HasForeignKey(x => x.ESG_DILE_Id);

            _ = modelBuilder.Entity<Escapegame>()
                            .HasOne(x => x.DifficultyLevel)
                            .WithMany()
                            .HasForeignKey(x => x.ESG_DILE_Id);

            _ = modelBuilder.Entity<Price>()
                            .HasKey(x=>x.Id);

            _ = modelBuilder.Entity<Escapegame>()
                          .HasOne(x => x.Price)
                          .WithMany()
                          .HasForeignKey(x => x.ESG_Price_Id);

            //Event-------------
            _ = modelBuilder.Entity<Event>().HasKey(x => x.EventId);

            _ = modelBuilder.Entity<Event>()
                            .HasOne(x=> x.Escapegame)
                            .WithMany(x=>x.Events)
                            .HasForeignKey(x=>x.EscapegameId);

            //SessionGame-------
            _ = modelBuilder.Entity<SessionGame>()
                            .HasKey(x=>x.SegId);
            //Categoris---------
            _ = modelBuilder.Entity<Categorie>()
                            .HasKey(x => x.CatId);
            _ = modelBuilder.Entity<SubCategorie>()
                          .HasKey(x => x.SubCatId);
            _ = modelBuilder.Entity<SubCategorie>()
                            .HasOne(x => x.Categorie)
                            .WithMany(x => x.SubCategories)
                            .HasForeignKey(x => x.CatId);
            //ActivityPlaces----
            _ = modelBuilder.Entity<ActivityPlaces>()
                            .HasKey(x => x.ActivityId);

            //ActivityPlaces----
            _ = modelBuilder.Entity<ActivityPlacesType>()
                            .HasKey(x => x.Id);
            //Favoris ----------
            _ = modelBuilder.Entity<Favoris>()
                            .HasKey(x => new 
                                { x.EscapeGameId });
            //Publication-------
            _ = modelBuilder.Entity<Publication>()
                            .HasKey(x => x.PubId);
            //derived
            //PublicationType---
            _ = modelBuilder.Entity<PublicationType>()
                            .HasKey(x => x.PublicationTypeId);
            
            //typeLIke----------
            _ = modelBuilder.Entity<TypeLike>().HasKey(x => x.TypeLikeId);
            //haslikez----------
            _ = modelBuilder.Entity<HasLike>().HasKey(x => x.Id);

            _ = modelBuilder.Entity<HasLike>().HasOne(x => x.Publication)
                                              .WithOne(x => x.HasLike)
                                              .HasForeignKey<HasLike>(x=>x.PubId);
            //hasbeenDone 
            _ = modelBuilder.Entity<HasBeenDone>().HasKey(x => x.HbdId);
            _ = modelBuilder.Entity<HasBeenDone>().HasOne(x => x.Escapegame).WithMany(x=>x.HasBeenDones).HasForeignKey(x=>x.EscapeGameId);  
            //Rating------------
            _ = modelBuilder.Entity<Rating>().HasKey(x => x.RateId);
            _ = modelBuilder.Entity<Rating>().HasOne(x=>x.HasbeenDone).WithOne().HasForeignKey<Rating>(x=>x.HasBeenDoneId);
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
