using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class cheating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompletedExam",
                table: "OnlineExamRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1415), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1431), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1432), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1444), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1446), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1298), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1299) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1331), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1263), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1505), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1513), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1371), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1370), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1376), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1379), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1378), new DateTime(2022, 12, 5, 7, 35, 1, 138, DateTimeKind.Local).AddTicks(1378) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompletedExam",
                table: "OnlineExamRoom");

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
    }
}
