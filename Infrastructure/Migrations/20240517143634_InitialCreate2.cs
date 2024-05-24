using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopCategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopSubcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShopCategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopSubcategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopSubcategories_Categories_ShopCategoryId",
                        column: x => x.ShopCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "decimal(18,2)", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductBrandId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductBrand_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BatteriesAndAccumItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteriesAndAccumItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatteriesAndAccumItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BedroomItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedroomItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BedroomItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishWasherItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Volume = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishWasherItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishWasherItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreezerItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Noise = table.Column<string>(type: "TEXT", nullable: false),
                    Volume = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreezerItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FreezerItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HallwayItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallwayItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HallwayItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeadphonesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadphonesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadphonesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitchenItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitchenItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KitchenItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenAccessoriesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenAccessoriesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenAccessoriesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenClothesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenClothesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenClothesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenShoesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenShoesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenShoesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MicrowaveItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Volume = table.Column<string>(type: "TEXT", nullable: true),
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicrowaveItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MicrowaveItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubSubcategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessories_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCDisplays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubSubcategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCDisplays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCDisplays_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPortables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubSubcategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPortables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPortables_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peripheries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubSubcategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peripheries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peripheries_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SmartphoneItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: true),
                    Resolution = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartphoneItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SmartphoneItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TVItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Display = table.Column<string>(type: "TEXT", nullable: true),
                    Resolution = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TVItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacuumCleanerItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Volume = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacuumCleanerItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacuumCleanerItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasherItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    Spin = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasherItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasherItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WomenAccessoriesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenAccessoriesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WomenAccessoriesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WomenClothesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenClothesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WomenClothesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WomenShoesItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopSubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenShoesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WomenShoesItems_ShopSubcategories_ShopSubcategoryId",
                        column: x => x.ShopSubcategoryId,
                        principalTable: "ShopSubcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessoryCPUItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Cores = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessoryCPUItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessoryCPUItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessoryGPUItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessoryGPUItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessoryGPUItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessoryHDDItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessoryHDDItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessoryHDDItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessoryMotherboardItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Socket = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessoryMotherboardItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessoryMotherboardItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessoryRAMItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessoryRAMItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessoryRAMItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCAccessorySSDItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCAccessoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCAccessorySSDItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCAccessorySSDItems_PCAccessories_PCAccessoryId",
                        column: x => x.PCAccessoryId,
                        principalTable: "PCAccessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCDisplayItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCDisplayId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Clock = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCDisplayItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCDisplayItems_PCDisplays_PCDisplayId",
                        column: x => x.PCDisplayId,
                        principalTable: "PCDisplays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPortableEbookItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPortableId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPortableEbookItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPortableEbookItem_PCPortables_PCPortableId",
                        column: x => x.PCPortableId,
                        principalTable: "PCPortables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPortableLaptopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPortableId = table.Column<int>(type: "INTEGER", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    RAM_Value = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPortableLaptopItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPortableLaptopItems_PCPortables_PCPortableId",
                        column: x => x.PCPortableId,
                        principalTable: "PCPortables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPortableTabletItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPortableId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPortableTabletItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPortableTabletItems_PCPortables_PCPortableId",
                        column: x => x.PCPortableId,
                        principalTable: "PCPortables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPeripheryKeyboardItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPeripheryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Linking = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPeripheryKeyboardItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPeripheryKeyboardItems_Peripheries_PCPeripheryId",
                        column: x => x.PCPeripheryId,
                        principalTable: "Peripheries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPeripheryMiceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPeripheryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Linking = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPeripheryMiceItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPeripheryMiceItems_Peripheries_PCPeripheryId",
                        column: x => x.PCPeripheryId,
                        principalTable: "Peripheries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCPeripheryWebCamItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PCPeripheryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Resolution = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCPeripheryWebCamItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCPeripheryWebCamItems_Peripheries_PCPeripheryId",
                        column: x => x.PCPeripheryId,
                        principalTable: "Peripheries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteriesAndAccumItems_ShopSubcategoryId",
                table: "BatteriesAndAccumItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BedroomItems_ShopSubcategoryId",
                table: "BedroomItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DishWasherItems_ShopSubcategoryId",
                table: "DishWasherItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FreezerItems_ShopSubcategoryId",
                table: "FreezerItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HallwayItems_ShopSubcategoryId",
                table: "HallwayItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadphonesItems_ShopSubcategoryId",
                table: "HeadphonesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_KitchenItems_ShopSubcategoryId",
                table: "KitchenItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenAccessoriesItems_ShopSubcategoryId",
                table: "MenAccessoriesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenClothesItems_ShopSubcategoryId",
                table: "MenClothesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenShoesItems_ShopSubcategoryId",
                table: "MenShoesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MicrowaveItems_ShopSubcategoryId",
                table: "MicrowaveItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeItems_ShopSubcategoryId",
                table: "OfficeItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessories_ShopSubcategoryId",
                table: "PCAccessories",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessoryCPUItems_PCAccessoryId",
                table: "PCAccessoryCPUItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessoryGPUItems_PCAccessoryId",
                table: "PCAccessoryGPUItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessoryHDDItems_PCAccessoryId",
                table: "PCAccessoryHDDItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessoryMotherboardItems_PCAccessoryId",
                table: "PCAccessoryMotherboardItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessoryRAMItems_PCAccessoryId",
                table: "PCAccessoryRAMItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCAccessorySSDItems_PCAccessoryId",
                table: "PCAccessorySSDItems",
                column: "PCAccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCDisplayItems_PCDisplayId",
                table: "PCDisplayItems",
                column: "PCDisplayId");

            migrationBuilder.CreateIndex(
                name: "IX_PCDisplays_ShopSubcategoryId",
                table: "PCDisplays",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPeripheryKeyboardItems_PCPeripheryId",
                table: "PCPeripheryKeyboardItems",
                column: "PCPeripheryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPeripheryMiceItems_PCPeripheryId",
                table: "PCPeripheryMiceItems",
                column: "PCPeripheryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPeripheryWebCamItems_PCPeripheryId",
                table: "PCPeripheryWebCamItems",
                column: "PCPeripheryId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPortableEbookItem_PCPortableId",
                table: "PCPortableEbookItem",
                column: "PCPortableId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPortableLaptopItems_PCPortableId",
                table: "PCPortableLaptopItems",
                column: "PCPortableId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPortableTabletItems_PCPortableId",
                table: "PCPortableTabletItems",
                column: "PCPortableId");

            migrationBuilder.CreateIndex(
                name: "IX_PCPortables_ShopSubcategoryId",
                table: "PCPortables",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Peripheries_ShopSubcategoryId",
                table: "Peripheries",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductBrandId",
                table: "Product",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeId",
                table: "Product",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopSubcategories_ShopCategoryId",
                table: "ShopSubcategories",
                column: "ShopCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SmartphoneItems_ShopSubcategoryId",
                table: "SmartphoneItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TVItems_ShopSubcategoryId",
                table: "TVItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VacuumCleanerItems_ShopSubcategoryId",
                table: "VacuumCleanerItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasherItems_ShopSubcategoryId",
                table: "WasherItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WomenAccessoriesItems_ShopSubcategoryId",
                table: "WomenAccessoriesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WomenClothesItems_ShopSubcategoryId",
                table: "WomenClothesItems",
                column: "ShopSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_WomenShoesItems_ShopSubcategoryId",
                table: "WomenShoesItems",
                column: "ShopSubcategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteriesAndAccumItems");

            migrationBuilder.DropTable(
                name: "BedroomItems");

            migrationBuilder.DropTable(
                name: "DishWasherItems");

            migrationBuilder.DropTable(
                name: "FreezerItems");

            migrationBuilder.DropTable(
                name: "HallwayItems");

            migrationBuilder.DropTable(
                name: "HeadphonesItems");

            migrationBuilder.DropTable(
                name: "KitchenItems");

            migrationBuilder.DropTable(
                name: "MenAccessoriesItems");

            migrationBuilder.DropTable(
                name: "MenClothesItems");

            migrationBuilder.DropTable(
                name: "MenShoesItems");

            migrationBuilder.DropTable(
                name: "MicrowaveItems");

            migrationBuilder.DropTable(
                name: "OfficeItems");

            migrationBuilder.DropTable(
                name: "PCAccessoryCPUItems");

            migrationBuilder.DropTable(
                name: "PCAccessoryGPUItems");

            migrationBuilder.DropTable(
                name: "PCAccessoryHDDItems");

            migrationBuilder.DropTable(
                name: "PCAccessoryMotherboardItems");

            migrationBuilder.DropTable(
                name: "PCAccessoryRAMItems");

            migrationBuilder.DropTable(
                name: "PCAccessorySSDItems");

            migrationBuilder.DropTable(
                name: "PCDisplayItems");

            migrationBuilder.DropTable(
                name: "PCPeripheryKeyboardItems");

            migrationBuilder.DropTable(
                name: "PCPeripheryMiceItems");

            migrationBuilder.DropTable(
                name: "PCPeripheryWebCamItems");

            migrationBuilder.DropTable(
                name: "PCPortableEbookItem");

            migrationBuilder.DropTable(
                name: "PCPortableLaptopItems");

            migrationBuilder.DropTable(
                name: "PCPortableTabletItems");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SmartphoneItems");

            migrationBuilder.DropTable(
                name: "TVItems");

            migrationBuilder.DropTable(
                name: "VacuumCleanerItems");

            migrationBuilder.DropTable(
                name: "WasherItems");

            migrationBuilder.DropTable(
                name: "WomenAccessoriesItems");

            migrationBuilder.DropTable(
                name: "WomenClothesItems");

            migrationBuilder.DropTable(
                name: "WomenShoesItems");

            migrationBuilder.DropTable(
                name: "PCAccessories");

            migrationBuilder.DropTable(
                name: "PCDisplays");

            migrationBuilder.DropTable(
                name: "Peripheries");

            migrationBuilder.DropTable(
                name: "PCPortables");

            migrationBuilder.DropTable(
                name: "ProductBrand");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "ShopSubcategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
