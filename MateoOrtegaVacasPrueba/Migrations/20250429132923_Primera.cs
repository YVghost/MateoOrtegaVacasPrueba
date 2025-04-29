using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MateoOrtegaVacasPrueba.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recompensa",
                columns: table => new
                {
                    idRecompensa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    puntos = table.Column<int>(type: "int", nullable: false),
                    tipoRecompensa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recompensa", x => x.idRecompensa);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    idReserva = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pagoreserva = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.idReserva);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    reservaVigente = table.Column<bool>(type: "bit", nullable: false),
                    totalGastos = table.Column<float>(type: "real", nullable: false),
                    mateoOrtegaVacas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idRecompensa = table.Column<int>(type: "int", nullable: false),
                    idReserva = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Recompensa_idRecompensa",
                        column: x => x.idRecompensa,
                        principalTable: "Recompensa",
                        principalColumn: "idRecompensa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_Reserva_idReserva",
                        column: x => x.idReserva,
                        principalTable: "Reserva",
                        principalColumn: "idReserva",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idRecompensa",
                table: "Cliente",
                column: "idRecompensa");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idReserva",
                table: "Cliente",
                column: "idReserva",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Recompensa");

            migrationBuilder.DropTable(
                name: "Reserva");
        }
    }
}
