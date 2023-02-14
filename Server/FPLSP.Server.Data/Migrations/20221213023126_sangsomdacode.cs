using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class sangsomdacode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    IdTeacher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.IdTeacher, x.IdSubject });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Lecturers_IdTeacher",
                        column: x => x.IdTeacher,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_SubjectUP_IdSubject",
                        column: x => x.IdSubject,
                        principalTable: "SubjectUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(426), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(431), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(435), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(441), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(211), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(229), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(234), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(373), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(379), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_IdSubject",
                table: "SubjectTeacher",
                column: "IdSubject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTeacher");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2238), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2254), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2260), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2261), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2264), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Unspecified).AddTicks(2277), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2176), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2179), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2139), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2315), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2320), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2326), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2212), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2211), new DateTime(2022, 12, 10, 7, 57, 19, 936, DateTimeKind.Local).AddTicks(2211) });
        }
    }
}
