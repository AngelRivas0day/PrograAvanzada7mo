using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UserPasswordMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "TrabajadorRegistro",
                value: "2efcb7b8-b974-4a38-a35d-3e9e6446405d");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
