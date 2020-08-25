using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountController = table.Column<string>(type: "varchar(12)", nullable: true),
                    BeneficaryName = table.Column<string>(type: "varchar(100)", nullable: true),
                    BankName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Code = table.Column<string>(type: "varchar(11)", nullable: true),
                    Amount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
