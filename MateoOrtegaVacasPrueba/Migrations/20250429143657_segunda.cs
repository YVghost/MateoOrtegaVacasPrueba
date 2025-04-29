using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MateoOrtegaVacasPrueba.Migrations
{
    /// <inheritdoc />
    public partial class segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_idRecompensa",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Reserva_idReserva",
                table: "Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_idRecompensa",
                table: "Cliente",
                column: "idRecompensa",
                principalTable: "Recompensa",
                principalColumn: "idRecompensa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Reserva_idReserva",
                table: "Cliente",
                column: "idReserva",
                principalTable: "Reserva",
                principalColumn: "idReserva",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_idRecompensa",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Reserva_idReserva",
                table: "Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_idRecompensa",
                table: "Cliente",
                column: "idRecompensa",
                principalTable: "Recompensa",
                principalColumn: "idRecompensa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Reserva_idReserva",
                table: "Cliente",
                column: "idReserva",
                principalTable: "Reserva",
                principalColumn: "idReserva",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
