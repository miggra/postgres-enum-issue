using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresEnumPrototype.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDeliveryStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:delivery_status", "in_progress,sent,delivered,error");

            migrationBuilder.AddColumn<int>(
                name: "delivery_status",
                table: "messages",
                type: "delivery_status",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "delivery_status",
                table: "messages");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:delivery_status", "in_progress,sent,delivered,error");
        }
    }
}
