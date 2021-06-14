using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioAcceso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuarios_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "d22114f3-a82f-4992-978f-fbf69f12443b");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "2191c2fd-0047-45d7-b952-54b00a47a0a3");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "62019920-240d-4b6a-80b1-be463d891d52");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "45c5b180-89e5-444e-aa34-3cd363765377");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                column: "TrabajadorRegistro",
                value: "2ada6ec2-35e5-42d3-9639-c28311685433");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "e4bdf940-ae8a-414c-8395-ff5023167b96");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "631fe688-1fbf-45c6-bdd0-ea669f4ae2db");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "176c9b60-730b-42e6-8b44-2939c9134c56");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "3e216c44-f3d4-4e07-b27e-f8074deddd7f");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "17d65c2d-d2db-4b61-8b74-2f18aef71364");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "3b27a67d-61c6-45b8-b7f3-962a50e759f9");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "5a4c53c7-05a4-498c-a9d6-89395d292403");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "6f7b82c5-b43d-471c-ba00-d040c1ac9f17");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "27d10371-374e-483e-a9c7-2d95a6c91bad");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "d12c3d00-7cbb-4baf-afd2-056baf513c57");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "cd13ff7e-8bf9-4793-8db8-5c7c6285016f");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TrabajadorId",
                table: "Usuarios",
                column: "TrabajadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "ff64d681-4335-4287-8d1c-9edac64dd6d3");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "873486d1-38fd-4478-9657-130c220d0605");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "4d42ce0f-7b27-4d57-b895-31159f9cadb4");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "c4e70ee4-49cd-49b7-b8fd-980ba8093138");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                column: "TrabajadorRegistro",
                value: "fa674223-72f5-4657-8fa7-e464737c35e9");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "96b9eb48-cf6c-48b7-b862-8398ef2e8800");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "9d9435a8-103c-4349-bcec-7443a44a581d");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "852e076c-1f06-448d-83f4-8cb4b79109b9");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "801cf1ed-cfc0-4414-a09d-2fe1723af290");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "3e1b7bd9-d146-4b94-bae0-8ca41fbf6a84");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "0706901f-30a4-433e-908b-9505279e4115");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "4c6f2ba3-3799-4a75-8a12-f6ed4cce66b7");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "8b28a9da-168c-4acf-ad1b-ce919991069a");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "9c4976f2-b47f-4e67-b753-096de2c672e2");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "4ed7576b-a77d-4f4d-8424-ac3f04422d9b");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "1cdecc73-47a4-4c20-9ec6-1931053da335");
        }
    }
}
