using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MateoOrtegaVacasPrueba.Migrations
{
    /// <inheritdoc />
    public partial class relacionesaditadas : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Cliente_idRecompensa",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_idReserva",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "idRecompensa",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "pagoreserva",
                table: "Reserva",
                newName: "PagoReserva");

            migrationBuilder.RenameColumn(
                name: "fechaSalida",
                table: "Reserva",
                newName: "FechaSalida");

            migrationBuilder.RenameColumn(
                name: "fechaEntrada",
                table: "Reserva",
                newName: "FechaEntrada");

            migrationBuilder.RenameColumn(
                name: "idReserva",
                table: "Reserva",
                newName: "IdReserva");

            migrationBuilder.RenameColumn(
                name: "tipoRecompensa",
                table: "Recompensa",
                newName: "TipoRecompensa");

            migrationBuilder.RenameColumn(
                name: "puntos",
                table: "Recompensa",
                newName: "Puntos");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Recompensa",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "fechaInicio",
                table: "Recompensa",
                newName: "FechaInicio");

            migrationBuilder.RenameColumn(
                name: "idRecompensa",
                table: "Recompensa",
                newName: "IdRecompensa");

            migrationBuilder.RenameColumn(
                name: "totalGastos",
                table: "Cliente",
                newName: "TotalGastos");

            migrationBuilder.RenameColumn(
                name: "reservaVigente",
                table: "Cliente",
                newName: "ReservaVigente");

            migrationBuilder.RenameColumn(
                name: "nombreCliente",
                table: "Cliente",
                newName: "NombreCliente");

            migrationBuilder.RenameColumn(
                name: "mateoOrtegaVacas",
                table: "Cliente",
                newName: "MateoOrtegaVacas");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Cliente",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Cliente",
                newName: "IdCliente");

            migrationBuilder.RenameColumn(
                name: "idReserva",
                table: "Cliente",
                newName: "PuntosAcumulados");

            migrationBuilder.AlterColumn<decimal>(
                name: "PagoReserva",
                table: "Reserva",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Recompensa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalGastos",
                table: "Cliente",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCliente",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MateoOrtegaVacas",
                table: "Cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteId",
                table: "Reserva",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Recompensa_ClienteId",
                table: "Recompensa",
                column: "ClienteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recompensa_Cliente_ClienteId",
                table: "Recompensa",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recompensa_Cliente_ClienteId",
                table: "Recompensa");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_ClienteId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Recompensa_ClienteId",
                table: "Recompensa");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Recompensa");

            migrationBuilder.RenameColumn(
                name: "PagoReserva",
                table: "Reserva",
                newName: "pagoreserva");

            migrationBuilder.RenameColumn(
                name: "FechaSalida",
                table: "Reserva",
                newName: "fechaSalida");

            migrationBuilder.RenameColumn(
                name: "FechaEntrada",
                table: "Reserva",
                newName: "fechaEntrada");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Reserva",
                newName: "idReserva");

            migrationBuilder.RenameColumn(
                name: "TipoRecompensa",
                table: "Recompensa",
                newName: "tipoRecompensa");

            migrationBuilder.RenameColumn(
                name: "Puntos",
                table: "Recompensa",
                newName: "puntos");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Recompensa",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Recompensa",
                newName: "fechaInicio");

            migrationBuilder.RenameColumn(
                name: "IdRecompensa",
                table: "Recompensa",
                newName: "idRecompensa");

            migrationBuilder.RenameColumn(
                name: "TotalGastos",
                table: "Cliente",
                newName: "totalGastos");

            migrationBuilder.RenameColumn(
                name: "ReservaVigente",
                table: "Cliente",
                newName: "reservaVigente");

            migrationBuilder.RenameColumn(
                name: "NombreCliente",
                table: "Cliente",
                newName: "nombreCliente");

            migrationBuilder.RenameColumn(
                name: "MateoOrtegaVacas",
                table: "Cliente",
                newName: "mateoOrtegaVacas");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Cliente",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Cliente",
                newName: "idCliente");

            migrationBuilder.RenameColumn(
                name: "PuntosAcumulados",
                table: "Cliente",
                newName: "idReserva");

            migrationBuilder.AlterColumn<float>(
                name: "pagoreserva",
                table: "Reserva",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "totalGastos",
                table: "Cliente",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "nombreCliente",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "mateoOrtegaVacas",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<int>(
                name: "idRecompensa",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idRecompensa",
                table: "Cliente",
                column: "idRecompensa");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idReserva",
                table: "Cliente",
                column: "idReserva",
                unique: true);

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
    }
}
