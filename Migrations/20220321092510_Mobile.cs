using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApi.Migrations
{
    public partial class Mobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //     migrationBuilder.EnsureSchema(
        //         name: "dbo");

        //     migrationBuilder.CreateSequence<int>(
        //         name: "id",
        //         schema: "dbo");

        //     migrationBuilder.CreateSequence<int>(
        //         name: "rollno",
        //         schema: "dbo");

            // migrationBuilder.CreateTable(
            //     name: "Datas",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         firstname = table.Column<string>(type: "text", nullable: true),
            //         lastname = table.Column<string>(type: "text", nullable: true),
            //         rollno = table.Column<int>(type: "integer", nullable: false),
            //         mark1 = table.Column<int>(type: "integer", nullable: false),
            //         mark2 = table.Column<int>(type: "integer", nullable: false),
            //         mark3 = table.Column<int>(type: "integer", nullable: false),
            //         totalmarks = table.Column<int>(type: "integer", nullable: false),
            //         result = table.Column<string>(type: "text", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Datas", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Logins",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         Email = table.Column<string>(type: "text", nullable: true),
            //         username = table.Column<string>(type: "text", nullable: true),
            //         password = table.Column<string>(type: "text", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Logins", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Marklists",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         rollno = table.Column<int>(type: "integer", nullable: false),
            //         mark1 = table.Column<int>(type: "integer", nullable: false),
            //         mark2 = table.Column<int>(type: "integer", nullable: false),
            //         mark3 = table.Column<int>(type: "integer", nullable: false),
            //         totalmarks = table.Column<int>(type: "integer", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Marklists", x => x.id);
            //     });

            migrationBuilder.CreateTable(
                name: "Mobiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    rollno = table.Column<int>(type: "integer", nullable: false),
                    image = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            // migrationBuilder.CreateTable(
            //     name: "StudentImages",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         rollno = table.Column<int>(type: "integer", nullable: false),
            //         image = table.Column<string>(type: "text", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_StudentImages", x => x.id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Students",
            //     columns: table => new
            //     {
            //         rollno = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         firstname = table.Column<string>(type: "text", nullable: true),
            //         lastname = table.Column<string>(type: "text", nullable: true),
            //         gender = table.Column<string>(type: "text", nullable: true),
            //         phoneno = table.Column<string>(type: "text", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Students", x => x.rollno);
            //     });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Marklists");

            migrationBuilder.DropTable(
                name: "Mobiles");

            migrationBuilder.DropTable(
                name: "StudentImages");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropSequence(
                name: "id",
                schema: "dbo");

            migrationBuilder.DropSequence(
                name: "rollno",
                schema: "dbo");
        }
    }
}
