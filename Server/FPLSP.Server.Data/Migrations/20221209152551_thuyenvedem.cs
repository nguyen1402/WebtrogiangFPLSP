using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class thuyenvedem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountTurnJoin",
                table: "OnlineExamRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsViewExamFile",
                table: "OnlineExamRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5046), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5067), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4992), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4936), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5122), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5131), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5021), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5021), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5020) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountTurnJoin",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "IsViewExamFile",
                table: "OnlineExamRoom");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9438), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9457), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9461), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9470), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9355), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9323), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9517), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9525), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9413) });
        }
    }
}
