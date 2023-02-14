using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class addstudentamount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8941), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8865), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8887), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8819), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8836), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8841), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9024), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9028), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6311), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6184), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6155), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6159), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6344), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6275) });
        }
    }
}
