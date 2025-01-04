using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscapeGameService.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityPlacesTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityPlacesTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPlacesTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityPlacesTypes_ActivityPlacesTypes_ActivityPlacesTypeId",
                        column: x => x.ActivityPlacesTypeId,
                        principalTable: "ActivityPlacesTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DayOftheWeeks",
                columns: table => new
                {
                    DowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DowName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayOftheWeeks", x => x.DowId);
                });

            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    DileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DileLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.DileId);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndicePrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    PubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscapegameId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikeNumber = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.PubId);
                });

            migrationBuilder.CreateTable(
                name: "PublicationTypes",
                columns: table => new
                {
                    PublicationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationTypes", x => x.PublicationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SessionGames",
                columns: table => new
                {
                    SegId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscapeGameId = table.Column<int>(type: "int", nullable: false),
                    GameTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    GameDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Placeavailable = table.Column<int>(type: "int", nullable: false),
                    PLacemaximum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionGames", x => x.SegId);
                });

            migrationBuilder.CreateTable(
                name: "TypeLike",
                columns: table => new
                {
                    TypeLikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeLikeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeLike", x => x.TypeLikeId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityPlaces",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcpId = table.Column<int>(type: "int", nullable: false),
                    AcpEsgId = table.Column<int>(type: "int", nullable: false),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgressources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPlaces", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_ActivityPlaces_ActivityPlacesTypes_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityPlacesTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Escapegames",
                columns: table => new
                {
                    ESGId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESGNom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGCreator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGImgResources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGWebsite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESGPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESG_IsDeleting = table.Column<bool>(type: "bit", nullable: false),
                    ESG_IsForChildren = table.Column<bool>(type: "bit", nullable: false),
                    ESG_Price_Id = table.Column<int>(type: "int", nullable: false),
                    ESG_DILE_Id = table.Column<int>(type: "int", nullable: false),
                    ESG_CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ESG_UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escapegames", x => x.ESGId);
                    table.ForeignKey(
                        name: "FK_Escapegames_DifficultyLevels_ESG_DILE_Id",
                        column: x => x.ESG_DILE_Id,
                        principalTable: "DifficultyLevels",
                        principalColumn: "DileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Escapegames_Prices_ESG_Price_Id",
                        column: x => x.ESG_Price_Id,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SessionReserveds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionGameId = table.Column<int>(type: "int", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updatedate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionReserveds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionReserveds_SessionGames_SessionGameId",
                        column: x => x.SessionGameId,
                        principalTable: "SessionGames",
                        principalColumn: "SegId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HasLike",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PubId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeLikeId = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasLike", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HasLike_Publications_PubId",
                        column: x => x.PubId,
                        principalTable: "Publications",
                        principalColumn: "PubId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HasLike_TypeLike_TypeLikeId",
                        column: x => x.TypeLikeId,
                        principalTable: "TypeLike",
                        principalColumn: "TypeLikeId");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscapegameESGId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatId);
                    table.ForeignKey(
                        name: "FK_Categories_Escapegames_EscapegameESGId",
                        column: x => x.EscapegameESGId,
                        principalTable: "Escapegames",
                        principalColumn: "ESGId");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscapegameId = table.Column<int>(type: "int", nullable: false),
                    EventTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Escapegames_EscapegameId",
                        column: x => x.EscapegameId,
                        principalTable: "Escapegames",
                        principalColumn: "ESGId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favoris",
                columns: table => new
                {
                    EscapeGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EscapegameESGId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoris", x => x.EscapeGameId);
                    table.ForeignKey(
                        name: "FK_Favoris_Escapegames_EscapegameESGId",
                        column: x => x.EscapegameESGId,
                        principalTable: "Escapegames",
                        principalColumn: "ESGId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HasBeenDones",
                columns: table => new
                {
                    HbdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EscapeGameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasBeenDones", x => x.HbdId);
                    table.ForeignKey(
                        name: "FK_HasBeenDones_Escapegames_EscapeGameId",
                        column: x => x.EscapeGameId,
                        principalTable: "Escapegames",
                        principalColumn: "ESGId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoris",
                columns: table => new
                {
                    SubCatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    SubCatName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoris", x => x.SubCatId);
                    table.ForeignKey(
                        name: "FK_SubCategoris_Categories_CatId",
                        column: x => x.CatId,
                        principalTable: "Categories",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasBeenDoneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_Rating_HasBeenDones_HasBeenDoneId",
                        column: x => x.HasBeenDoneId,
                        principalTable: "HasBeenDones",
                        principalColumn: "HbdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPlaces_ActivityTypeId",
                table: "ActivityPlaces",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPlacesTypes_ActivityPlacesTypeId",
                table: "ActivityPlacesTypes",
                column: "ActivityPlacesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EscapegameESGId",
                table: "Categories",
                column: "EscapegameESGId");

            migrationBuilder.CreateIndex(
                name: "IX_Escapegames_ESG_DILE_Id",
                table: "Escapegames",
                column: "ESG_DILE_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Escapegames_ESG_Price_Id",
                table: "Escapegames",
                column: "ESG_Price_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EscapegameId",
                table: "Events",
                column: "EscapegameId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoris_EscapegameESGId",
                table: "Favoris",
                column: "EscapegameESGId");

            migrationBuilder.CreateIndex(
                name: "IX_HasBeenDones_EscapeGameId",
                table: "HasBeenDones",
                column: "EscapeGameId");

            migrationBuilder.CreateIndex(
                name: "IX_HasLike_PubId",
                table: "HasLike",
                column: "PubId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HasLike_TypeLikeId",
                table: "HasLike",
                column: "TypeLikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_HasBeenDoneId",
                table: "Rating",
                column: "HasBeenDoneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SessionReserveds_SessionGameId",
                table: "SessionReserveds",
                column: "SessionGameId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoris_CatId",
                table: "SubCategoris",
                column: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPlaces");

            migrationBuilder.DropTable(
                name: "DayOftheWeeks");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Favoris");

            migrationBuilder.DropTable(
                name: "HasLike");

            migrationBuilder.DropTable(
                name: "PublicationTypes");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "SessionReserveds");

            migrationBuilder.DropTable(
                name: "SubCategoris");

            migrationBuilder.DropTable(
                name: "ActivityPlacesTypes");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "TypeLike");

            migrationBuilder.DropTable(
                name: "HasBeenDones");

            migrationBuilder.DropTable(
                name: "SessionGames");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Escapegames");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");

            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}
