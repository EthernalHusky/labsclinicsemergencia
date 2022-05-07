using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Shared.Migrations
{
    public partial class med_corr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Medicos_MedicoId",
                table: "Examenes");

            migrationBuilder.RenameColumn(
                name: "MedicoId",
                table: "Examenes",
                newName: "MedicosId");

            migrationBuilder.RenameIndex(
                name: "IX_Examenes_MedicoId",
                table: "Examenes",
                newName: "IX_Examenes_MedicosId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c06eaf3-10d4-40ae-bd00-3d50d629cfde",
                column: "ConcurrencyStamp",
                value: "354ab6a2-b07f-4144-9658-93ec63d13382");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e725ea5-282e-401c-9e82-da4947e382ef",
                column: "ConcurrencyStamp",
                value: "9214761d-ea91-4ef5-92ea-c3e77534eaa0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785c160e-6a4f-4fd8-8121-4e6b2af230cd",
                column: "ConcurrencyStamp",
                value: "5d35d7a3-3b99-44cd-86df-a981e0e87b0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2716b4b-671d-4814-a04c-b51aa97051e8",
                column: "ConcurrencyStamp",
                value: "c8efe9bd-8e26-4331-a2bd-a78fff4b4571");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec320394-8501-4710-a2ae-85e04315a5f9",
                column: "ConcurrencyStamp",
                value: "039bdaf7-eec4-4a26-a54e-ac1b8aebdfa7");

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Medicos_MedicosId",
                table: "Examenes",
                column: "MedicosId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examenes_Medicos_MedicosId",
                table: "Examenes");

            migrationBuilder.RenameColumn(
                name: "MedicosId",
                table: "Examenes",
                newName: "MedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Examenes_MedicosId",
                table: "Examenes",
                newName: "IX_Examenes_MedicoId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c06eaf3-10d4-40ae-bd00-3d50d629cfde",
                column: "ConcurrencyStamp",
                value: "b4ead64c-b109-491c-b6d8-c5626c23d4b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e725ea5-282e-401c-9e82-da4947e382ef",
                column: "ConcurrencyStamp",
                value: "dfe4c4af-db8a-4a38-a549-284267eed413");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "785c160e-6a4f-4fd8-8121-4e6b2af230cd",
                column: "ConcurrencyStamp",
                value: "9682f4bd-9224-4c8f-90d5-6b18492519e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2716b4b-671d-4814-a04c-b51aa97051e8",
                column: "ConcurrencyStamp",
                value: "a8eac364-c985-437e-a99b-7b28424e971b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec320394-8501-4710-a2ae-85e04315a5f9",
                column: "ConcurrencyStamp",
                value: "dc6eb2f2-a577-44ca-9963-b9bda097345d");

            migrationBuilder.AddForeignKey(
                name: "FK_Examenes_Medicos_MedicoId",
                table: "Examenes",
                column: "MedicoId",
                principalTable: "Medicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
