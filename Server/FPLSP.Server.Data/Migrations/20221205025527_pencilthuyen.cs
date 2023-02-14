using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class pencilthuyen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "ExamStorage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ExamStorage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "IdBlock",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSemester",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_IdBlock_IdSemester",
                table: "ExaminationRoomDetail",
                columns: new[] { "IdBlock", "IdSemester" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_SemesterBlock_IdBlock_IdSemester",
                table: "ExaminationRoomDetail",
                columns: new[] { "IdBlock", "IdSemester" },
                principalTable: "SemesterBlock",
                principalColumns: new[] { "IdBlock", "IdSemester" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_SemesterBlock_IdBlock_IdSemester",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomDetail_IdBlock_IdSemester",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "IdBlock",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "IdSemester",
                table: "ExaminationRoomDetail");

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
    }
}
