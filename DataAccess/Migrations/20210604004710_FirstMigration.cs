using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academias",
                columns: table => new
                {
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademiaNombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academias", x => x.AcademiaId);
                });

            migrationBuilder.CreateTable(
                name: "DireccionEntity",
                columns: table => new
                {
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionCalle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DireccionNoExt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionNoInt = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionCp = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DireccionMunicipio = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionEntity", x => x.DireccionId);
                });

            migrationBuilder.CreateTable(
                name: "Plazas",
                columns: table => new
                {
                    PlazaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlazaTipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plazas", x => x.PlazaId);
                });

            migrationBuilder.CreateTable(
                name: "Planteles",
                columns: table => new
                {
                    PlantelId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantelNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planteles", x => x.PlantelId);
                    table.ForeignKey(
                        name: "FK_Planteles_DireccionEntity_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "DireccionEntity",
                        principalColumn: "DireccionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trabajadores",
                columns: table => new
                {
                    TrabajadorNomina = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    TrabajadorRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrabajadorNombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorApPaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorApMaterno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorCurp = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorTelefono = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorCelular = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TrabajadorEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PlantelId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    DireccionId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    PlazaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajadores", x => x.TrabajadorNomina);
                    table.ForeignKey(
                        name: "FK_Trabajadores_DireccionEntity_DireccionId",
                        column: x => x.DireccionId,
                        principalTable: "DireccionEntity",
                        principalColumn: "DireccionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trabajadores_Planteles_PlantelId",
                        column: x => x.PlantelId,
                        principalTable: "Planteles",
                        principalColumn: "PlantelId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Trabajadores_Plazas_PlazaId",
                        column: x => x.PlazaId,
                        principalTable: "Plazas",
                        principalColumn: "PlazaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jefes",
                columns: table => new
                {
                    JefeId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jefes", x => x.JefeId);
                    table.ForeignKey(
                        name: "FK_Jefes_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "AcademiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jefes_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermisoTipo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PermisoFechaElaboracion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoFechaAplicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermisoFechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    JefeInmediatoId = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    PermisoEstado = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK_Permisos_Trabajadores_JefeInmediatoId",
                        column: x => x.JefeInmediatoId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permisos_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puestos",
                columns: table => new
                {
                    PuestoId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrabajadorId = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    AcademiaId = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puestos", x => x.PuestoId);
                    table.ForeignKey(
                        name: "FK_Puestos_Academias_AcademiaId",
                        column: x => x.AcademiaId,
                        principalTable: "Academias",
                        principalColumn: "AcademiaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Puestos_Trabajadores_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "Trabajadores",
                        principalColumn: "TrabajadorNomina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Academias",
                columns: new[] { "AcademiaId", "AcademiaNombre" },
                values: new object[,]
                {
                    { 1, "Computacion" },
                    { 2, "Redes y sistemas" },
                    { 3, "Informatica" }
                });

            migrationBuilder.InsertData(
                table: "DireccionEntity",
                columns: new[] { "DireccionId", "DireccionCalle", "DireccionCp", "DireccionMunicipio", "DireccionNoExt", "DireccionNoInt" },
                values: new object[,]
                {
                    { 19, "Felix Mendelssohn", "45030", "Zapopan", "5682", "" },
                    { 18, "Agustin Lara", "45037", "Zapopan", "5774", "" },
                    { 17, "Economos", "45037", "Zapopan", "5524", "" },
                    { 16, "Av Moctezuma", "45050", "Zapopan", "348", "" },
                    { 15, "Kabah", "45050", "Zapopan", "1475", "" },
                    { 14, "Av Mayas", "44670", "Gualadajara", "3322", "" },
                    { 13, "Domingo Sarmiento", "44670", "Gualadajara", "2922", "" },
                    { 12, "Calle Jose Enrique Rodo", "44670", "Gualadajara", "2783", "" },
                    { 11, "Milan", "44630", "Gualadajara", "2654", "" },
                    { 9, "Calle Montreal", "44630", "Gualadajara", "1587", "" },
                    { 8, "Calle Nicolas Romero", "44260", "Gualadajara", "1328A", "" },
                    { 7, "Avenida Alcalde", "45190", "Zapopan", "2510", "6" },
                    { 6, "Domingo de Alzola", "44220", "Gualadajara", "1134", "" },
                    { 5, "Santa Elena Alcalde", "44220", "Gualadajara", "56", "" },
                    { 4, "Salto del Agua", "44210", "Gualadajara", "2415", "" },
                    { 3, "Loma Dorada Norte", "45418", "Tonala", "8962", "" },
                    { 2, "Camino a Matatlan", "45435", "Tonala", "2400", "" },
                    { 1, "Calle Nueva Escocia", "44630", "Guadalajara", "1885", "" },
                    { 10, "Valparaiso", "44630", "Gualadajara", "2579", "" }
                });

            migrationBuilder.InsertData(
                table: "Plazas",
                columns: new[] { "PlazaId", "PlazaTipo" },
                values: new object[,]
                {
                    { 1, "fija" },
                    { 2, "no fija" }
                });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 1, 1, "CETI Colomos" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 2, 2, "CETI Rio Santiago" });

            migrationBuilder.InsertData(
                table: "Planteles",
                columns: new[] { "PlantelId", "DireccionId", "PlantelNombre" },
                values: new object[] { 3, 3, "CETI Tonala" });

            migrationBuilder.InsertData(
                table: "Trabajadores",
                columns: new[] { "TrabajadorNomina", "DireccionId", "PlantelId", "PlazaId", "TrabajadorApMaterno", "TrabajadorApPaterno", "TrabajadorCelular", "TrabajadorCurp", "TrabajadorEmail", "TrabajadorNombre", "TrabajadorRegistro", "TrabajadorTelefono" },
                values: new object[,]
                {
                    { "836", 4, 1, 1, "GONZÁLEZ", "GÓMEZ", "3345678901", "XEXX010101MNEXXXA8", "zbins@mills.biz", "YESENIA", "ca6c0f89-b245-4d34-981c-1fb798deb57a", "3318826414" },
                    { "520", 5, 1, 1, "LOZANO", "ABRAHAM", "3391176908", "XEXX010101HNEXXXA4", "mmoore@gmail.com", "AKIRA", "71eff5e4-0484-4922-aa46-5ea1d77d961f", "3372586983" },
                    { "969", 6, 1, 1, "HERNÁNDEZ", "FERRER", "3332185477", "XEXX010101MNEXXXA8", "josiah.pacocha@gmail.com", "SUSANA ELIZABETH", "1b137edc-1f36-474e-8983-73231eeaceb6", "3319871231" },
                    { "662", 7, 1, 1, "HERNÁNDEZ", "FERRER", "3333244215", "XEXX010101MNEXXXA8", "stoltenberg.keshawn@yahoo.com", "SUSANA ELIZABETH", "335593c5-6746-4a98-879a-2e36be1f2df5", "3361564758" },
                    { "870", 8, 1, 1, "DAMIAN", "GARCÍA", "3390971710", "XEXX010101HNEXXXA4", "piper33@block.org", "JUAN MANUEL", "5d250823-0b6c-4f71-9472-30b9d3410836", "3389908711" },
                    { "142", 9, 2, 1, "COLIN", "SANTANA", "3387144259", "XEXX010101HNEXXXA4", "pbalistreri@gmail.com", "CARLOS TOMAS", "035a43a6-011f-4bc4-be19-0cdd70c3e2a5", "3312160223" },
                    { "106", 10, 2, 1, "OYARZABAL", "PLAZA", "3341024910", "XEXX010101HNEXXXA4", "benedict73@yahoo.com", "ERNESTO ALEJANDRO", "7e9a183f-95b2-4266-9fcf-894c2b9b798d", "3363713078" },
                    { "728", 11, 2, 1, "GÓMEZ", "VARGAS", "3347681797", "XEXX010101MNEXXXA8", "abigayle.mann@gmail.com", "AGUSTINA", "88f7c416-19c1-4f6f-a917-8960e73942c8", "3347681797" },
                    { "861", 12, 2, 1, "CANTÚ", "GÁNDARA", "3301261506", "XEXX010101MNEXXXA8", "eddie.prosacco@will.com", "LOURDES", "1b5aaa54-0b8b-4368-9c9f-071b7ff8f2d8", "3344970611" },
                    { "675", 13, 2, 1, "GONZÁLEZ", "LOZANO", "3315038946", "XEXX010101HNEXXXA4", "purdy.leonora@hudson.com", "ANTONIO", "f6f2941f-75a7-4d1b-a1d3-3d5aaef6478d", "3392928159" },
                    { "972", 14, 3, 1, "DURÁN", "GARCÍA", "3317914443", "XEXX010101MNEXXXA8", "frami.terence@dubuque.com", "CLARA GABRIELA", "4009f5a3-8f7d-42d0-8aa5-cdc0e022999d", "3339752838" },
                    { "779", 15, 3, 1, "CAMPA", "PAMPLONA", "3326431305", "XEXX010101HNEXXXA4", "bradtke.torrey@yahoo.com", "JORGE", "df208e57-9be7-4759-aaf5-dba983141aff", "3320068241" },
                    { "656", 16, 3, 1, "TORRES", "IBAÑEZ", "3330028955", "XEXX010101MNEXXXA8", "thora.hirthe@gmail.com", "SONIA ERIKA", "d973208a-cf8a-4f5b-852a-335886d8f785", "3307889594" },
                    { "991", 17, 3, 1, "TORRES", "ALCARAZ", "3361607678", "XEXX010101MNEXXXA8", "vicenta72@gmail.com", "ALEJANDRA", "ae214ded-afdf-4187-a962-7f670b93b366", "3379836327" },
                    { "669", 18, 3, 1, "CARGÍA", "CORNEJO", "3345559416", "XEXX010101MNEXXXA8", "xgoodwin@schinner.com", "MARTHA", "38a905b4-4b33-4846-b645-60b3a7df3557", "3330112050" },
                    { "500", 19, 3, 1, "DELGADO", "BECERRA", "3370661957", "XEXX010101HNEXXXA4", "nelson45@yahoo.com", "SERGIO", "a9ce51df-1908-46ff-bba7-b73b747a014b", "3348810059" }
                });

            migrationBuilder.InsertData(
                table: "Jefes",
                columns: new[] { "JefeId", "AcademiaId", "TrabajadorId" },
                values: new object[,]
                {
                    { 1, 1, "836" },
                    { 2, 2, "728" },
                    { 3, 3, "500" }
                });

            migrationBuilder.InsertData(
                table: "Puestos",
                columns: new[] { "PuestoId", "AcademiaId", "TrabajadorId" },
                values: new object[,]
                {
                    { 15, 3, "669" },
                    { 14, 3, "991" },
                    { 13, 3, "656" },
                    { 12, 3, "779" },
                    { 11, 3, "972" },
                    { 10, 2, "675" },
                    { 9, 2, "861" },
                    { 8, 2, "728" },
                    { 6, 2, "142" },
                    { 5, 1, "870" },
                    { 4, 1, "662" },
                    { 3, 1, "969" },
                    { 2, 1, "520" },
                    { 1, 1, "836" },
                    { 7, 2, "106" },
                    { 16, 3, "500" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jefes_AcademiaId",
                table: "Jefes",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jefes_TrabajadorId",
                table: "Jefes",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_JefeInmediatioTrabajadorNomina",
                table: "Permisos",
                column: "JefeInmediatioTrabajadorNomina");

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_TrabajadorId",
                table: "Permisos",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Planteles_DireccionId",
                table: "Planteles",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Puestos_AcademiaId",
                table: "Puestos",
                column: "AcademiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Puestos_TrabajadorId",
                table: "Puestos",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_DireccionId",
                table: "Trabajadores",
                column: "DireccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_PlantelId",
                table: "Trabajadores",
                column: "PlantelId");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajadores_PlazaId",
                table: "Trabajadores",
                column: "PlazaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jefes");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Puestos");

            migrationBuilder.DropTable(
                name: "Academias");

            migrationBuilder.DropTable(
                name: "Trabajadores");

            migrationBuilder.DropTable(
                name: "Planteles");

            migrationBuilder.DropTable(
                name: "Plazas");

            migrationBuilder.DropTable(
                name: "DireccionEntity");
        }
    }
}
