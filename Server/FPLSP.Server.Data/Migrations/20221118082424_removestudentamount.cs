using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class removestudentamount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentAmount",
                table: "ClassUp");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1445), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1446), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1450), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1325), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1328), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1256), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1272), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1276), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1500), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1506), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1357), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1356), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1360), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1359), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1406), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1406), new DateTime(2022, 11, 18, 15, 24, 23, 368, DateTimeKind.Local).AddTicks(1405) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentAmount",
                table: "ClassUp",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(467), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(652), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(657), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542) });
        }
    }
}
