using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class Csharper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CabinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexOfCabin = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexOfFeedBack = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FeedBackTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentOfFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdStudent = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBack_StudentUP_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "StudentUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeedBack_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShiftOfCabin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexOfShift = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftOfCabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingCabin",
                columns: table => new
                {
                    IdCabin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckinImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CheckinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckoutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexOfBookingCabin = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdLectuter = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCabin", x => x.IdCabin);
                    table.ForeignKey(
                        name: "FK_BookingCabin_Cabin_IdCabin",
                        column: x => x.IdCabin,
                        principalTable: "Cabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingCabin_ShiftOfCabin_IdShift",
                        column: x => x.IdShift,
                        principalTable: "ShiftOfCabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingCabin_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeachingSchedule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdAdminImport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexOfTeachingSchedule = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_ShiftOfCabin_IdShift",
                        column: x => x.IdShift,
                        principalTable: "ShiftOfCabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7267), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7270), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Unspecified).AddTicks(7272), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7197), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7229), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 11, 10, 13, 54, 57, 925, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCabin_IdShift",
                table: "BookingCabin",
                column: "IdShift");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCabin_SubjectId_ClassId",
                table: "BookingCabin",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_IdStudent",
                table: "FeedBack",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_SubjectId_ClassId",
                table: "FeedBack",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_IdShift",
                table: "TeachingSchedule",
                column: "IdShift");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_SubjectId_ClassId",
                table: "TeachingSchedule",
                columns: new[] { "SubjectId", "ClassId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingCabin");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "TeachingSchedule");

            migrationBuilder.DropTable(
                name: "Cabin");

            migrationBuilder.DropTable(
                name: "ShiftOfCabin");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7447), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7463), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7464), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7470), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7470), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7471), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7474), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Unspecified).AddTicks(7475), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7311), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7315), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7319), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7238), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7262), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7267), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7503), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7512), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7515), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7356), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7360), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7359), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7363), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7362), new DateTime(2022, 10, 10, 23, 34, 33, 942, DateTimeKind.Local).AddTicks(7362) });
        }
    }
}
