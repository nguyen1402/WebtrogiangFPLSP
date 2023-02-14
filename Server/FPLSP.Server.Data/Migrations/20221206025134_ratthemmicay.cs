using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class ratthemmicay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdSubject",
                table: "ResourceLinkUP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSubject",
                table: "ResourceLinkCP",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "OnlineExamRoom",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IndexOfStudent",
                table: "OnlineExamRoom",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ExamFile",
                table: "ExamStorage",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExaminationRoomName",
                table: "ExaminationRoom",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "ResourceLinkUP");

            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "ResourceLinkCP");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "OnlineExamRoom",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndexOfStudent",
                table: "OnlineExamRoom",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "ExamFile",
                table: "ExamStorage",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExaminationRoomName",
                table: "ExaminationRoom",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2355), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2368), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2373), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2374), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2375), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2378), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2379), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2280), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2295), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2299), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2238), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2256), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2499), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2325), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2324), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2328), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2327), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2331), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 12, 5, 9, 55, 25, 939, DateTimeKind.Local).AddTicks(2330) });
        }
    }
}
