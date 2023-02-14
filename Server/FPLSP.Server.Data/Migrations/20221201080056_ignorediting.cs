using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class ignorediting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEditing",
                table: "TeachingSchedule");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8527), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8543), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8591), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8478), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8449), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8454), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8621), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8504), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8503), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8507), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8506), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8509), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8509), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8508) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEditing",
                table: "TeachingSchedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7357), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7360), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7362), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7268), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7464), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7391), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7395), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7396) });
        }
    }
}
