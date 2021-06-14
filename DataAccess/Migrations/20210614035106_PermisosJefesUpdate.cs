using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class PermisosJefesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jefes_Academias_AcademiaId",
                table: "Jefes");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "019a98a0-8243-4bbf-b4db-4dfd0d9216ab");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "0c75e87c-5d4a-49b2-b33c-8aad08b66e91");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "139198bc-24b7-4faa-ad5f-90f56a73c8ba");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "15c866bb-b516-418c-b7ab-0b5e7c117ed9");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "2c8e6126-b243-4626-a40e-eee543a01def");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "34025c33-2aed-4e40-94c8-ec90aad97d32");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "4201ab89-5003-4c1f-ab0d-b666f1bb62b3");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "509bc163-0035-4ce4-8156-1bdcacb22c59");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "56a8087d-e8e7-4fab-b1a4-e4411230b714");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "5bf8fa81-010c-46ef-a0f1-58734e8ff60b");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "7d79a7d4-2a5d-4af7-b480-d63d571b9af3");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "7fd00e30-b287-4faa-9f77-fbe89ef6df91");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "95cf45e4-9566-4a90-8c81-c98434ed80fd");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "a04daf8c-d5ab-4cab-a66c-d17afd7c4033");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "d7c918f2-fe72-45e2-aa78-2ae2a0891242");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "e86571bb-97d2-4b5d-b4fe-0143febe2654");

            migrationBuilder.AddColumn<int>(
                name: "PermisoEliminado",
                table: "Permisos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AcademiaId",
                table: "Jefes",
                type: "int",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11);

            migrationBuilder.AddColumn<int>(
                name: "JefeTotal",
                table: "Jefes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "JefeId", "AcademiaId", "JefeTotal", "TrabajadorId" },
                values: new object[] { 4, null, 1, "669" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "7c9dc202-8da0-4583-b20f-42271eb005ff");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "7bdbf972-4f4d-412d-98b2-56a8f516e53c");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "c6c1e23f-4a97-43f4-b36a-492e7354c879");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "c4f40c5d-26a8-4424-8f01-27ffe7a6a826");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                columns: new[] { "PlazaId", "TrabajadorRegistro" },
                values: new object[] { 2, "8d342b07-71ca-49fd-aa23-9a881908941d" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "9e28a85e-c4ed-4c68-b533-938779e68cd5");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "cda8f83b-2982-4e53-96b9-08d8acc4fb69");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "0876ae00-c449-41b6-9681-fc8421d5d220");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "930673f0-3e01-49dc-9146-bd880a580849");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "45d8803e-7f07-4ca0-ac62-eba07fbd7ade");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "cdcffe5f-8493-4336-b7c5-05295c954c12");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "0a6a639f-5e81-40ba-b294-4968171b6a06");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "5e78c21e-a718-4fd3-a692-50dbf803a5c8");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "d377ac19-e2ef-463a-a0b0-ec2f00dde422");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "7a85516a-3567-43c6-9ff8-b4ad64b9d695");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "c94f9449-12b6-4193-938c-9bc5e2380a59");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "TrabajadorId", "UsuarioAcceso" },
                values: new object[,]
                {
                    { "f1bb2266-17b1-4e08-baae-a7bbf3682800", "836", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "b7fb0fa6-43ff-41c2-8272-48e946013af3", "520", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "b403ff50-c324-46be-8ac0-d5a81bf28d28", "662", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "2730371c-31de-46e5-8f8f-47ed506e7099", "669", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "9ef0e2c9-9a87-4326-92e3-f4c5bca1d2b9", "991", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "fdaf595e-7cac-4cfd-9024-7dc14a05a3b5", "656", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "2d467dbe-6ab1-49e1-bf9e-bd24a70fd4ab", "779", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "1c0e7dfb-6870-4c21-9851-8640355352d0", "972", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "89f26266-6323-4a61-bbf6-a9ae146676b5", "675", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "ed8843b9-813b-4bf5-858f-3c3593d4f87d", "861", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "1cbc975f-aef0-4853-8192-e271a9809c0b", "728", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "13ea985a-a6ea-48bd-9d47-ab7e7fbe6aea", "106", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "50a78c8c-179f-434a-9414-222ea6a0e43b", "142", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "d9d9d4f8-03ef-45e3-8d77-e2383298d215", "870", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "7a745ad3-74b7-431b-8d9d-ca5212ef9400", "969", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "5946ccbf-a9f7-4a0a-ab54-4ccb2bff460e", "500", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jefes_Academias_AcademiaId",
                table: "Jefes",
                column: "AcademiaId",
                principalTable: "Academias",
                principalColumn: "AcademiaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jefes_Academias_AcademiaId",
                table: "Jefes");

            migrationBuilder.DeleteData(
                table: "Jefes",
                keyColumn: "JefeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "13ea985a-a6ea-48bd-9d47-ab7e7fbe6aea");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "1c0e7dfb-6870-4c21-9851-8640355352d0");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "1cbc975f-aef0-4853-8192-e271a9809c0b");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "2730371c-31de-46e5-8f8f-47ed506e7099");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "2d467dbe-6ab1-49e1-bf9e-bd24a70fd4ab");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "50a78c8c-179f-434a-9414-222ea6a0e43b");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "5946ccbf-a9f7-4a0a-ab54-4ccb2bff460e");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "7a745ad3-74b7-431b-8d9d-ca5212ef9400");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "89f26266-6323-4a61-bbf6-a9ae146676b5");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "9ef0e2c9-9a87-4326-92e3-f4c5bca1d2b9");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "b403ff50-c324-46be-8ac0-d5a81bf28d28");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "b7fb0fa6-43ff-41c2-8272-48e946013af3");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "d9d9d4f8-03ef-45e3-8d77-e2383298d215");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "ed8843b9-813b-4bf5-858f-3c3593d4f87d");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "f1bb2266-17b1-4e08-baae-a7bbf3682800");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: "fdaf595e-7cac-4cfd-9024-7dc14a05a3b5");

            migrationBuilder.DropColumn(
                name: "PermisoEliminado",
                table: "Permisos");

            migrationBuilder.DropColumn(
                name: "JefeTotal",
                table: "Jefes");

            migrationBuilder.AlterColumn<int>(
                name: "AcademiaId",
                table: "Jefes",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "106",
                column: "TrabajadorRegistro",
                value: "516b1639-29a7-44d6-9eb4-c74186d9b7eb");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "142",
                column: "TrabajadorRegistro",
                value: "7805017c-a5a5-4d1b-a98e-51d1809b4f35");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "500",
                column: "TrabajadorRegistro",
                value: "e1bcb6a4-9fec-49bb-ae31-b74b193b8ca2");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "520",
                column: "TrabajadorRegistro",
                value: "91ca69e7-4443-47ef-9b64-aa0be00b6d18");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "656",
                columns: new[] { "PlazaId", "TrabajadorRegistro" },
                values: new object[] { 1, "2efcb7b8-b974-4a38-a35d-3e9e6446405d" });

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "662",
                column: "TrabajadorRegistro",
                value: "bd69edc9-bff3-4202-af71-dd56da0d7efb");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "669",
                column: "TrabajadorRegistro",
                value: "f9c3eb8a-b302-4c86-acf3-91c7afcbff03");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "675",
                column: "TrabajadorRegistro",
                value: "1a220064-51b5-4637-b362-7aafca42116e");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "728",
                column: "TrabajadorRegistro",
                value: "7a531531-d658-421f-aec5-afeec94d59bc");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "779",
                column: "TrabajadorRegistro",
                value: "cefea567-f4dd-476b-9365-9290e23b923e");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "836",
                column: "TrabajadorRegistro",
                value: "6bb89359-2b97-44df-8ba6-b3fcac0718d4");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "861",
                column: "TrabajadorRegistro",
                value: "368b6a57-1ef7-4359-849a-837b3dc821b1");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "870",
                column: "TrabajadorRegistro",
                value: "dfd0e158-ccc9-4be9-a98e-5ab5c31b341c");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "969",
                column: "TrabajadorRegistro",
                value: "93037857-c53a-41ef-8fed-6dc9eb120959");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "972",
                column: "TrabajadorRegistro",
                value: "726f764d-64d2-4f6e-a627-b32f33efa309");

            migrationBuilder.UpdateData(
                table: "Trabajadores",
                keyColumn: "TrabajadorNomina",
                keyValue: "991",
                column: "TrabajadorRegistro",
                value: "97acf795-294e-497a-9c3e-d0e1b4c75922");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "TrabajadorId", "UsuarioAcceso" },
                values: new object[,]
                {
                    { "019a98a0-8243-4bbf-b4db-4dfd0d9216ab", "500", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "7d79a7d4-2a5d-4af7-b480-d63d571b9af3", "991", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "5bf8fa81-010c-46ef-a0f1-58734e8ff60b", "656", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "7fd00e30-b287-4faa-9f77-fbe89ef6df91", "779", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "509bc163-0035-4ce4-8156-1bdcacb22c59", "972", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "2c8e6126-b243-4626-a40e-eee543a01def", "675", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "15c866bb-b516-418c-b7ab-0b5e7c117ed9", "861", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "0c75e87c-5d4a-49b2-b33c-8aad08b66e91", "728", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "4201ab89-5003-4c1f-ab0d-b666f1bb62b3", "106", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "e86571bb-97d2-4b5d-b4fe-0143febe2654", "142", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "d7c918f2-fe72-45e2-aa78-2ae2a0891242", "870", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "a04daf8c-d5ab-4cab-a66c-d17afd7c4033", "662", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "95cf45e4-9566-4a90-8c81-c98434ed80fd", "969", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "34025c33-2aed-4e40-94c8-ec90aad97d32", "520", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "139198bc-24b7-4faa-ad5f-90f56a73c8ba", "669", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" },
                    { "56a8087d-e8e7-4fab-b1a4-e4411230b714", "836", "ayhoRaUL22sbbmJX3ZFdPH+cnLPrUC6qAbUIi2zw0GA=" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jefes_Academias_AcademiaId",
                table: "Jefes",
                column: "AcademiaId",
                principalTable: "Academias",
                principalColumn: "AcademiaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
