using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class seeyouagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7053), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7055), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7058), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6951), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6972), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6975), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6905), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6922), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7187), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7193), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7198), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7005), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7005), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7008), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7007), new DateTime(2022, 12, 5, 7, 33, 12, 480, DateTimeKind.Local).AddTicks(7007) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7352), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7249), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7266), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7269), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7138), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7151), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7386), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7396), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7298), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7301) });
        }
    }
}
