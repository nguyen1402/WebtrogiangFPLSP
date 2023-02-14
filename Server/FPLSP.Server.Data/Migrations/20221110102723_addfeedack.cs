using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class addfeedack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedBackOutSide",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentOfFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBackOutSide", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(938), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(796), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(815), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(818), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(755), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(771), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(969), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(975), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(979), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(838), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(842), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(841), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(887), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(886), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(886) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBackOutSide");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7270), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7197), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7229), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7228) });
        }
    }
}
