using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PermisoMotivo",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "74ed4e26-c24e-42b5-96cc-e1e2cef9d06c");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "68815feb-f350-4f19-b495-4acbfb83a959");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "bdc1d602-7091-476f-b2c5-2b04b5b3afc7");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "8c4b20e1-11ba-4015-bd14-9d80db2a940e");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                column: "TrabajadorRegistro",
                value: "437110d5-911c-4eeb-abb4-3ee1c37cf5cf");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "2889b864-1153-4420-a97e-8250e6b8498b");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "9389362c-fdfe-4d6f-9091-b69806a1f2d6");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "86e1d65e-5d7b-40ed-a482-f3d73304a883");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "0a8193d4-11a4-4a4e-adcd-0c2d9c0f9a11");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "8d54b4d2-8999-47ef-b8dc-e8a0a71ee176");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "fcf6dd1b-c55a-4da2-8512-ccaf7c476833");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "79cf5a9b-ec74-4c58-862e-f68c079c645e");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "562bbc9e-915b-4ac3-b6e0-3a851d0a0081");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "e562d8bb-5421-4808-8b8f-d1fbfc890d24");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "61e9985c-5bba-4819-a83d-3ae3184822a3");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "e4311dc7-173a-423f-953a-bcc77186027a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermisoMotivo",
                table: "Permisos");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "40f631d6-1cad-4a02-bb88-68f178811482");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "725f95e5-9fdc-45d0-af87-3285bd38abbb");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "3157a411-271d-4887-8718-31ea47cf2593");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "eceebd66-8527-4a43-9ec0-e43e718baa6a");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                column: "TrabajadorRegistro",
                value: "8d04eb03-f9b4-44c6-89b1-c831f7120469");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "d6d651e8-db6d-4ea4-96b2-4e2df7d660ac");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "5b648f9f-224c-46ed-a7ff-15d91b471eaf");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "dd913091-3895-48e8-84c5-8b4859cb6588");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "0cb62fc6-0912-450d-87fb-8ec3dae3d946");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "e9d0e34e-fe54-48c5-9891-b71b57b5bdf2");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "3f55ef7c-daec-476d-a2aa-5f8ce65fd927");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "260b5759-ba66-4153-8f62-ecb313b00367");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "f855ed09-3a76-44ba-b70a-6ae340dfb625");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "f58c4006-caff-4308-aec6-1c3b6ba0632a");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "d5aa23bb-178c-4e35-a0ed-203b995fd68f");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "2658f6d4-f3cc-41f4-af17-eba8c6b95494");
        }
    }
}
