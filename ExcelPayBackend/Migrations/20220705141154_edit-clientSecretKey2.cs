using Microsoft.EntityFrameworkCore.Migrations;

namespace ExcelPayBackend.Migrations
{
    public partial class editclientSecretKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExpired",
                table: "ClientSecrets");

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicKey", "SecretKey" },
                values: new object[] { "MEgCQQCow/N0auA7kNHXM8i4XEveHr+b1aGBHrdYAo9tWb51mxDbfHjB5sgdpgIW5EoA39yVzObqQSbTCXldK7zRc52fAgMBAAE=", "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad+H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4+bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91/pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c/7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW/yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH+5Cu94XIZA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExpired",
                table: "ClientSecrets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicKey", "SecretKey" },
                values: new object[] { "MEgCQQCow/N0auA7kNHXM8i4XEveHr+b1aGBHrdYAo9tWb51mxDbfHjB5sgdpgIW5EoA39yVzObqQSbTCXldK7zRc52fAgMBAAE = ", "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad + H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4 + bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91 / pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c / 7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW / yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH + 5Cu94XIZA == " });
        }
    }
}
