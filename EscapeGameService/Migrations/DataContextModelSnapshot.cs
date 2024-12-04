﻿// <auto-generated />
using System;
using EscapeGameService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EscapeGameService.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EscapeGameService.Models.ActivityPlaces", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"));

                    b.Property<int>("AcpEsgId")
                        .HasColumnType("int");

                    b.Property<int>("AcpId")
                        .HasColumnType("int");

                    b.Property<int?>("ActivityTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imgressources")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityId");

                    b.HasIndex("ActivityTypeId");

                    b.ToTable("ActivityPlaces");
                });

            modelBuilder.Entity("EscapeGameService.Models.ActivityPlacesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ActivityPlacesTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityPlacesTypeId");

                    b.ToTable("ActivityPlacesTypes");
                });

            modelBuilder.Entity("EscapeGameService.Models.Categorie", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatId"));

                    b.Property<string>("CatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EscapegameESGId")
                        .HasColumnType("int");

                    b.HasKey("CatId");

                    b.HasIndex("EscapegameESGId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EscapeGameService.Models.DayOftheWeek", b =>
                {
                    b.Property<int>("DowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DowId"));

                    b.Property<string>("DowName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DowId");

                    b.ToTable("DayOftheWeeks");
                });

            modelBuilder.Entity("EscapeGameService.Models.DifficultyLevel", b =>
                {
                    b.Property<int>("DileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DileId"));

                    b.Property<string>("DileLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DileId");

                    b.ToTable("DifficultyLevels");
                });

            modelBuilder.Entity("EscapeGameService.Models.Escapegame", b =>
                {
                    b.Property<int>("ESGId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ESGId"));

                    b.Property<string>("ESGContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGCreator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGImgResources")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGNom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESGWebsite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ESG_CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ESG_DILE_Id")
                        .HasColumnType("int");

                    b.Property<bool>("ESG_IsDeleting")
                        .HasColumnType("bit");

                    b.Property<bool>("ESG_IsForChildren")
                        .HasColumnType("bit");

                    b.Property<int>("ESG_Price_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("ESG_UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ESGId");

                    b.HasIndex("ESG_DILE_Id");

                    b.HasIndex("ESG_Price_Id");

                    b.ToTable("Escapegames");
                });

            modelBuilder.Entity("EscapeGameService.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EscapegameId")
                        .HasColumnType("int");

                    b.Property<string>("EventDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EventId");

                    b.HasIndex("EscapegameId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EscapeGameService.Models.Favoris", b =>
                {
                    b.Property<int>("EscapeGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EscapeGameId"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EscapegameESGId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EscapeGameId");

                    b.HasIndex("EscapegameESGId");

                    b.ToTable("Favoris");
                });

            modelBuilder.Entity("EscapeGameService.Models.HasBeenDone", b =>
                {
                    b.Property<int>("HbdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HbdId"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EscapeGameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HbdId");

                    b.HasIndex("EscapeGameId");

                    b.ToTable("HasBeenDones");
                });

            modelBuilder.Entity("EscapeGameService.Models.HasLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PubId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeLikeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PubId")
                        .IsUnique();

                    b.HasIndex("TypeLikeId");

                    b.ToTable("HasLike");
                });

            modelBuilder.Entity("EscapeGameService.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IndicePrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("EscapeGameService.Models.Publication", b =>
                {
                    b.Property<int>("PubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PubId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EscapegameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LikeNumber")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PubId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("EscapeGameService.Models.PublicationType", b =>
                {
                    b.Property<int>("PublicationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublicationTypeId"));

                    b.Property<string>("PublicationTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublicationTypeId");

                    b.ToTable("PublicationTypes");
                });

            modelBuilder.Entity("EscapeGameService.Models.Rating", b =>
                {
                    b.Property<int>("RateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RateId"));

                    b.Property<int>("HasBeenDoneId")
                        .HasColumnType("int");

                    b.Property<string>("RateContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RateId");

                    b.HasIndex("HasBeenDoneId")
                        .IsUnique();

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("EscapeGameService.Models.SessionGame", b =>
                {
                    b.Property<int>("SegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SegId"));

                    b.Property<int>("EscapeGameId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("GameDate")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("GameTime")
                        .HasColumnType("time");

                    b.Property<int>("PLacemaximum")
                        .HasColumnType("int");

                    b.Property<int>("Placeavailable")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("SegId");

                    b.ToTable("SessionGames");
                });

            modelBuilder.Entity("EscapeGameService.Models.SessionReserved", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Iscancel")
                        .HasColumnType("bit");

                    b.Property<int>("SessionGameId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updatedate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SessionGameId");

                    b.ToTable("SessionReserveds");
                });

            modelBuilder.Entity("EscapeGameService.Models.SubCategorie", b =>
                {
                    b.Property<int>("SubCatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCatId"));

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("SubCatName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCatId");

                    b.HasIndex("CatId");

                    b.ToTable("SubCategoris");
                });

            modelBuilder.Entity("EscapeGameService.Models.TypeLike", b =>
                {
                    b.Property<int>("TypeLikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeLikeId"));

                    b.Property<string>("TypeLikeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeLikeId");

                    b.ToTable("TypeLike");
                });

            modelBuilder.Entity("EscapeGameService.Models.ActivityPlaces", b =>
                {
                    b.HasOne("EscapeGameService.Models.ActivityPlacesType", "ActivityType")
                        .WithMany()
                        .HasForeignKey("ActivityTypeId");

                    b.Navigation("ActivityType");
                });

            modelBuilder.Entity("EscapeGameService.Models.ActivityPlacesType", b =>
                {
                    b.HasOne("EscapeGameService.Models.ActivityPlacesType", null)
                        .WithMany("ActivityPlaces")
                        .HasForeignKey("ActivityPlacesTypeId");
                });

            modelBuilder.Entity("EscapeGameService.Models.Categorie", b =>
                {
                    b.HasOne("EscapeGameService.Models.Escapegame", null)
                        .WithMany("Categories")
                        .HasForeignKey("EscapegameESGId");
                });

            modelBuilder.Entity("EscapeGameService.Models.Escapegame", b =>
                {
                    b.HasOne("EscapeGameService.Models.DifficultyLevel", "DifficultyLevel")
                        .WithMany()
                        .HasForeignKey("ESG_DILE_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscapeGameService.Models.Price", "Price")
                        .WithMany()
                        .HasForeignKey("ESG_Price_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DifficultyLevel");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("EscapeGameService.Models.Event", b =>
                {
                    b.HasOne("EscapeGameService.Models.Escapegame", "Escapegame")
                        .WithMany("Events")
                        .HasForeignKey("EscapegameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escapegame");
                });

            modelBuilder.Entity("EscapeGameService.Models.Favoris", b =>
                {
                    b.HasOne("EscapeGameService.Models.Escapegame", "Escapegame")
                        .WithMany()
                        .HasForeignKey("EscapegameESGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escapegame");
                });

            modelBuilder.Entity("EscapeGameService.Models.HasBeenDone", b =>
                {
                    b.HasOne("EscapeGameService.Models.Escapegame", "Escapegame")
                        .WithMany("HasBeenDones")
                        .HasForeignKey("EscapeGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escapegame");
                });

            modelBuilder.Entity("EscapeGameService.Models.HasLike", b =>
                {
                    b.HasOne("EscapeGameService.Models.Publication", "Publication")
                        .WithOne("HasLike")
                        .HasForeignKey("EscapeGameService.Models.HasLike", "PubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscapeGameService.Models.TypeLike", "TypeLIke")
                        .WithMany()
                        .HasForeignKey("TypeLikeId");

                    b.Navigation("Publication");

                    b.Navigation("TypeLIke");
                });

            modelBuilder.Entity("EscapeGameService.Models.Rating", b =>
                {
                    b.HasOne("EscapeGameService.Models.HasBeenDone", "HasbeenDone")
                        .WithOne()
                        .HasForeignKey("EscapeGameService.Models.Rating", "HasBeenDoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HasbeenDone");
                });

            modelBuilder.Entity("EscapeGameService.Models.SessionReserved", b =>
                {
                    b.HasOne("EscapeGameService.Models.SessionGame", "SessionGame")
                        .WithMany()
                        .HasForeignKey("SessionGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SessionGame");
                });

            modelBuilder.Entity("EscapeGameService.Models.SubCategorie", b =>
                {
                    b.HasOne("EscapeGameService.Models.Categorie", "Categorie")
                        .WithMany("SubCategories")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("EscapeGameService.Models.ActivityPlacesType", b =>
                {
                    b.Navigation("ActivityPlaces");
                });

            modelBuilder.Entity("EscapeGameService.Models.Categorie", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("EscapeGameService.Models.Escapegame", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Events");

                    b.Navigation("HasBeenDones");
                });

            modelBuilder.Entity("EscapeGameService.Models.Publication", b =>
                {
                    b.Navigation("HasLike");
                });
#pragma warning restore 612, 618
        }
    }
}
