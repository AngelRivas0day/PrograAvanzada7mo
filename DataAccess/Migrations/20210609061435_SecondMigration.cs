using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TrabajadorFechaNacimiento",
                table: "Trabajadores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PlazaFechaInicio",
                table: "Puestos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 1,
                column: "PlazaFechaInicio",
                value: new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 2,
                column: "PlazaFechaInicio",
                value: new DateTime(2001, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 3,
                column: "PlazaFechaInicio",
                value: new DateTime(2002, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 4,
                column: "PlazaFechaInicio",
                value: new DateTime(2003, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 5,
                column: "PlazaFechaInicio",
                value: new DateTime(2004, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 6,
                column: "PlazaFechaInicio",
                value: new DateTime(2005, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 7,
                column: "PlazaFechaInicio",
                value: new DateTime(2006, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 8,
                column: "PlazaFechaInicio",
                value: new DateTime(2007, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 9,
                column: "PlazaFechaInicio",
                value: new DateTime(2008, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 10,
                column: "PlazaFechaInicio",
                value: new DateTime(2009, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 11,
                column: "PlazaFechaInicio",
                value: new DateTime(2010, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 12,
                column: "PlazaFechaInicio",
                value: new DateTime(2011, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 13,
                column: "PlazaFechaInicio",
                value: new DateTime(2012, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 14,
                column: "PlazaFechaInicio",
                value: new DateTime(2013, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 15,
                column: "PlazaFechaInicio",
                value: new DateTime(2014, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Puestos",
                keyColumn: "PuestoId",
                keyValue: 16,
                column: "PlazaFechaInicio",
                value: new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1987, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "40f631d6-1cad-4a02-bb88-68f178811482" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1986, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "725f95e5-9fdc-45d0-af87-3285bd38abbb" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1996, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3157a411-271d-4887-8718-31ea47cf2593" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "eceebd66-8527-4a43-9ec0-e43e718baa6a" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1982, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "8d04eb03-f9b4-44c6-89b1-c831f7120469" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1984, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "d6d651e8-db6d-4ea4-96b2-4e2df7d660ac" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1970, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "5b648f9f-224c-46ed-a7ff-15d91b471eaf" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1979, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd913091-3895-48e8-84c5-8b4859cb6588" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0cb62fc6-0912-450d-87fb-8ec3dae3d946" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1978, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "e9d0e34e-fe54-48c5-9891-b71b57b5bdf2" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1976, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "3f55ef7c-daec-476d-a2aa-5f8ce65fd927" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1989, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "260b5759-ba66-4153-8f62-ecb313b00367" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "f855ed09-3a76-44ba-b70a-6ae340dfb625" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1983, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "f58c4006-caff-4308-aec6-1c3b6ba0632a" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1977, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "d5aa23bb-178c-4e35-a0ed-203b995fd68f" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                columns: new[] { "TrabajadorFechaNacimiento", "TrabajadorRegistro" },
                values: new object[] { new DateTime(1980, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "2658f6d4-f3cc-41f4-af17-eba8c6b95494" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrabajadorFechaNacimiento",
                table: "Trabajadores");

            migrationBuilder.DropColumn(
                name: "PlazaFechaInicio",
                table: "Puestos");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "7e9a183f-95b2-4266-9fcf-894c2b9b798d");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "035a43a6-011f-4bc4-be19-0cdd70c3e2a5");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "a9ce51df-1908-46ff-bba7-b73b747a014b");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "71eff5e4-0484-4922-aa46-5ea1d77d961f");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                column: "TrabajadorRegistro",
                value: "d973208a-cf8a-4f5b-852a-335886d8f785");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "335593c5-6746-4a98-879a-2e36be1f2df5");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "38a905b4-4b33-4846-b645-60b3a7df3557");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "f6f2941f-75a7-4d1b-a1d3-3d5aaef6478d");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "88f7c416-19c1-4f6f-a917-8960e73942c8");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "df208e57-9be7-4759-aaf5-dba983141aff");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "ca6c0f89-b245-4d34-981c-1fb798deb57a");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "1b5aaa54-0b8b-4368-9c9f-071b7ff8f2d8");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "5d250823-0b6c-4f71-9472-30b9d3410836");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "1b137edc-1f36-474e-8983-73231eeaceb6");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "4009f5a3-8f7d-42d0-8aa5-cdc0e022999d");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "ae214ded-afdf-4187-a962-7f670b93b366");
        }
    }
}
