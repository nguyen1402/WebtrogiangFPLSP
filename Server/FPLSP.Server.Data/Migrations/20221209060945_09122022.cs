using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class _09122022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTimeOfExam",
                table: "ExamStorage");

            migrationBuilder.AddColumn<int>(
                name: "TotalTimeOfExam",
                table: "ExaminationRoomDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2001), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2143), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2056), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2055), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2060) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalTimeOfExam",
                table: "ExaminationRoomDetail");

            migrationBuilder.AddColumn<int>(
                name: "TotalTimeOfExam",
                table: "ExamStorage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5440), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5453), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4968), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5517), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5341), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5347) });
        }
    }
}
