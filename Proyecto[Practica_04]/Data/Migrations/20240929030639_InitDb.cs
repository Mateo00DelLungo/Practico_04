using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    enPromocion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Turnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Turnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T_Detalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    servicio_id = table.Column<int>(type: "int", nullable: false),
                    turno_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Detalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Detalles_T_Servicios_servicio_id",
                        column: x => x.servicio_id,
                        principalTable: "T_Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Detalles_T_Turnos_turno_id",
                        column: x => x.turno_id,
                        principalTable: "T_Turnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Detalles_servicio_id",
                table: "T_Detalles",
                column: "servicio_id");

            migrationBuilder.CreateIndex(
                name: "IX_T_Detalles_turno_id",
                table: "T_Detalles",
                column: "turno_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Detalles");

            migrationBuilder.DropTable(
                name: "T_Servicios");

            migrationBuilder.DropTable(
                name: "T_Turnos");
        }
    }
}
