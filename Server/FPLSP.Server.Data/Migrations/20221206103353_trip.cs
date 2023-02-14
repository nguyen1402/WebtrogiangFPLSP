using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class trip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6177), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6245), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6256), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5981), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5915), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6371), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6381), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6122), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6125) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1330), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1342), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1343), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1348), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1349), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1353), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1353), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Unspecified).AddTicks(1354), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1267), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1271), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1274), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1386), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1302), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1308), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 12, 6, 9, 51, 33, 685, DateTimeKind.Local).AddTicks(1307) });
        }
    }
}
