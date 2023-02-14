using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class updateallownull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YearsOfExperience",
                table: "Lecturers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YearsOfExperience",
                table: "Lecturers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5742), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5662), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5766), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5772), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5693), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5692), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5699), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5699), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5698) });
        }
    }
}
