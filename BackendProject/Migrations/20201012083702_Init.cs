using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackendProject.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUsTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    FieldName = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true),
                    SharedTitle = table.Column<string>(maxLength: 50, nullable: true),
                    SharedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeHeroSlider",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    Desc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeHeroSlider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurBlogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurBlogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurPortfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true),
                    PortfolioButton = table.Column<string>(maxLength: 50, nullable: true),
                    Photo = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurPortfolios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Header = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromoButtons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Icon = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoButtons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicesCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(maxLength: 100, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 50, nullable: true),
                    HeaderPhone = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teamTwoCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(maxLength: 100, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    SocialLinks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teamTwoCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamTwoTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTwoTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestimonialCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Blockquote = table.Column<string>(maxLength: 200, nullable: true),
                    ClientName = table.Column<string>(maxLength: 50, nullable: true),
                    ClientPosition = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestimonialCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Desc = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsTexts");

            migrationBuilder.DropTable(
                name: "BlogCards");

            migrationBuilder.DropTable(
                name: "HomeHeroSlider");

            migrationBuilder.DropTable(
                name: "OurBlogs");

            migrationBuilder.DropTable(
                name: "OurPortfolios");

            migrationBuilder.DropTable(
                name: "PromoBlocks");

            migrationBuilder.DropTable(
                name: "PromoButtons");

            migrationBuilder.DropTable(
                name: "Promos");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ServicesCards");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "teamTwoCards");

            migrationBuilder.DropTable(
                name: "TeamTwoTexts");

            migrationBuilder.DropTable(
                name: "TestimonialCards");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
