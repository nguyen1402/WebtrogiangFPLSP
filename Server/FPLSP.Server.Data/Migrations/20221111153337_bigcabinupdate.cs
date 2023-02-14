using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class bigcabinupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin");

            migrationBuilder.DropIndex(
                name: "IX_BookingCabin_SubjectId_ClassId",
                table: "BookingCabin");

            migrationBuilder.DropColumn(
                name: "ClassroomCode",
                table: "ClassUp");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ClassUp");

            migrationBuilder.DropColumn(
                name: "DateStarted",
                table: "ClassUp");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "ClassUp");

            migrationBuilder.AddColumn<Guid>(
                name: "IdBlock",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSemester",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterBlockIdBlock",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SemesterBlockIdSemester",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "SubjectClassUP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarted",
                table: "SubjectClassUP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "SubjectClassUP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin",
                columns: new[] { "SubjectId", "ClassId", "IdCabin", "IdShift" });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameOfBlock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexOfBlock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexOfBookingRequest = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SendingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentOfRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdLectuter = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCabin = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingRequest_Cabin_IdCabin",
                        column: x => x.IdCabin,
                        principalTable: "Cabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingRequest_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupCabin",
                columns: table => new
                {
                    IdSpec = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCabin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupCabinName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfGrouping = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexOfGroupCabin = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SpecializedSubjectUPSpecializedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpecializedSubjectUPSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCabin", x => new { x.IdCabin, x.IdSpec });
                    table.ForeignKey(
                        name: "FK_GroupCabin_Cabin_IdCabin",
                        column: x => x.IdCabin,
                        principalTable: "Cabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupCabin_SpecializedSubjectUP_SpecializedSubjectUPSpecializedId_SpecializedSubjectUPSubjectId",
                        columns: x => new { x.SpecializedSubjectUPSpecializedId, x.SpecializedSubjectUPSubjectId },
                        principalTable: "SpecializedSubjectUP",
                        principalColumns: new[] { "SpecializedId", "SubjectId" });
                    table.ForeignKey(
                        name: "FK_GroupCabin_SpecializedUP_IdSpec",
                        column: x => x.IdSpec,
                        principalTable: "SpecializedUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameofSemester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexOfSemester = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SemesterBlock",
                columns: table => new
                {
                    IdBlock = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSemester = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "date", nullable: false),
                    EndTime = table.Column<DateTime>(type: "date", nullable: false),
                    IndexOfSemesterBlock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterBlock", x => new { x.IdBlock, x.IdSemester });
                    table.ForeignKey(
                        name: "FK_SemesterBlock_Block_IdBlock",
                        column: x => x.IdBlock,
                        principalTable: "Block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SemesterBlock_Semester_IdSemester",
                        column: x => x.IdSemester,
                        principalTable: "Semester",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3826), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3844), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3845), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3848), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3849), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3850), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3731), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3665), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3686), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3691), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3899), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3905), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3799), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3799), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3802), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3802), new DateTime(2022, 11, 11, 22, 33, 36, 596, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule",
                columns: new[] { "SemesterBlockIdBlock", "SemesterBlockIdSemester" });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCabin_IdCabin",
                table: "BookingCabin",
                column: "IdCabin");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRequest_IdCabin",
                table: "BookingRequest",
                column: "IdCabin");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRequest_SubjectId_ClassId",
                table: "BookingRequest",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupCabin_IdSpec",
                table: "GroupCabin",
                column: "IdSpec");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCabin_SpecializedSubjectUPSpecializedId_SpecializedSubjectUPSubjectId",
                table: "GroupCabin",
                columns: new[] { "SpecializedSubjectUPSpecializedId", "SpecializedSubjectUPSubjectId" });

            migrationBuilder.CreateIndex(
                name: "IX_SemesterBlock_IdSemester",
                table: "SemesterBlock",
                column: "IdSemester");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule",
                columns: new[] { "SemesterBlockIdBlock", "SemesterBlockIdSemester" },
                principalTable: "SemesterBlock",
                principalColumns: new[] { "IdBlock", "IdSemester" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropTable(
                name: "BookingRequest");

            migrationBuilder.DropTable(
                name: "GroupCabin");

            migrationBuilder.DropTable(
                name: "SemesterBlock");

            migrationBuilder.DropTable(
                name: "Block");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropIndex(
                name: "IX_TeachingSchedule_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin");

            migrationBuilder.DropIndex(
                name: "IX_BookingCabin_IdCabin",
                table: "BookingCabin");

            migrationBuilder.DropColumn(
                name: "IdBlock",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "IdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "SemesterBlockIdBlock",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "SubjectClassUP");

            migrationBuilder.DropColumn(
                name: "DateStarted",
                table: "SubjectClassUP");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "SubjectClassUP");

            migrationBuilder.AddColumn<string>(
                name: "ClassroomCode",
                table: "ClassUp",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "LH0");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ClassUp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStarted",
                table: "ClassUp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "ClassUp",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin",
                column: "IdCabin");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(921), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(922), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(925), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(926), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(927), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(930), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Unspecified).AddTicks(938), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(796), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(815), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(818), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(755), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(771), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(969), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(975), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(979), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(839), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(838), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(842), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(841), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(887), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(886), new DateTime(2022, 11, 10, 17, 27, 22, 883, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCabin_SubjectId_ClassId",
                table: "BookingCabin",
                columns: new[] { "SubjectId", "ClassId" });
        }
    }
}
