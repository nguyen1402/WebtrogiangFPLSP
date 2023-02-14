using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class thuyencapnhatdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8127), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8128), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8133), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8133), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8142), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Unspecified).AddTicks(8143), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8056), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8061), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8064), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8012), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8027), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8032), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8166), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8172), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8177), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8087), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8087), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 10, 1, 11, 0, 30, 829, DateTimeKind.Local).AddTicks(8093) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2007), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2018), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2024), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2026), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2030), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2031), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Unspecified).AddTicks(2032), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1944), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1947), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1889), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2057), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2066), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2070), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1975), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1975), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1979), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1983), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 9, 29, 22, 49, 41, 452, DateTimeKind.Local).AddTicks(1981) });
        }
    }
}
