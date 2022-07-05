using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelPayBackend.Migrations
{
    public partial class editclientSecretKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    IsExpired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSecrets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecretKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iframes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    merchantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iframes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Iframes_Merchants_merchantId",
                        column: x => x.merchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Intentions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientSecretId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    MerchantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intentions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intentions_ClientSecrets_ClientSecretId",
                        column: x => x.ClientSecretId,
                        principalTable: "ClientSecrets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Intentions_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "Name", "PublicKey", "SecretKey" },
                values: new object[] { 1, "Amr", "MEgCQQCow/N0auA7kNHXM8i4XEveHr+b1aGBHrdYAo9tWb51mxDbfHjB5sgdpgIW5EoA39yVzObqQSbTCXldK7zRc52fAgMBAAE = ", "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad + H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4 + bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91 / pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c / 7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW / yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH + 5Cu94XIZA == " });

            migrationBuilder.CreateIndex(
                name: "IX_Iframes_merchantId",
                table: "Iframes",
                column: "merchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Intentions_ClientSecretId",
                table: "Intentions",
                column: "ClientSecretId");

            migrationBuilder.CreateIndex(
                name: "IX_Intentions_MerchantId",
                table: "Intentions",
                column: "MerchantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iframes");

            migrationBuilder.DropTable(
                name: "Intentions");

            migrationBuilder.DropTable(
                name: "ClientSecrets");

            migrationBuilder.DropTable(
                name: "Merchants");
        }
    }
}
