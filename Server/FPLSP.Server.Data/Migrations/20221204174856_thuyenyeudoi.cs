using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class thuyenyeudoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectClassUP_SubjectId_ClassId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_SubjectClassUP_SubjectId_ClassId",
                table: "ExamStorage");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropTable(
                name: "LecturterExamSchedules");

            migrationBuilder.DropTable(
                name: "ExamSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_SupervisorExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_OnlineExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_SubjectId_ClassId",
                table: "ExamStorage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomStorage",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomDetail_SubjectId_ClassId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "ExaminationRoomDetail");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "ExamStorage",
                newName: "IdUserUpLoad");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "OnlineExamRoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "OnlineExamRoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserSignInId",
                table: "ExamStorage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecretKey",
                table: "ExaminationRoomDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "IdLecturter", "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom",
                columns: new[] { "IdStudent", "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomStorage",
                table: "ExaminationRoomStorage",
                columns: new[] { "IdExamFile", "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7322), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7341), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7342), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7346), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Unspecified).AddTicks(7352), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7249), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7266), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7269), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7138), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7151), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7386), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7396), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7298), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 12, 5, 0, 48, 55, 791, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_SubjectId",
                table: "ExamStorage",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_UserSignInId",
                table: "ExamStorage",
                column: "UserSignInId");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_SubjectUP_SubjectId",
                table: "ExamStorage",
                column: "SubjectId",
                principalTable: "SubjectUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_UserSignIn_UserSignInId",
                table: "ExamStorage",
                column: "UserSignInId",
                principalTable: "UserSignIn",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_SubjectUP_SubjectId",
                table: "ExamStorage");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_UserSignIn_UserSignInId",
                table: "ExamStorage");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_SupervisorExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_OnlineExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_SubjectId",
                table: "ExamStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_UserSignInId",
                table: "ExamStorage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomStorage",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "UserSignInId",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "SecretKey",
                table: "ExaminationRoomDetail");

            migrationBuilder.RenameColumn(
                name: "IdUserUpLoad",
                table: "ExamStorage",
                newName: "ClassId");

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "SupervisorExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "SupervisorExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "OnlineExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "OnlineExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "ExaminationRoomStorage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "ExaminationRoomStorage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "IdLecturter", "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom",
                columns: new[] { "IdStudent", "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomStorage",
                table: "ExaminationRoomStorage",
                columns: new[] { "IdExamFile", "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateTable(
                name: "ExamSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdBlock = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTrainingFacility = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSemester = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    IdAdminImport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexOfExamSchedule = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_SemesterBlock_IdBlock_IdSemester",
                        columns: x => new { x.IdBlock, x.IdSemester },
                        principalTable: "SemesterBlock",
                        principalColumns: new[] { "IdBlock", "IdSemester" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_ShiftOfCabin_IdShift",
                        column: x => x.IdShift,
                        principalTable: "ShiftOfCabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamSchedules_TrainingFacilitiesCP_IdTrainingFacility",
                        column: x => x.IdTrainingFacility,
                        principalTable: "TrainingFacilitiesCP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LecturterExamSchedules",
                columns: table => new
                {
                    IdLectuter = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExamSchedule = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsMainLectuter = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturterExamSchedules", x => new { x.IdLectuter, x.IdExamSchedule });
                    table.ForeignKey(
                        name: "FK_LecturterExamSchedules_ExamSchedules_IdExamSchedule",
                        column: x => x.IdExamSchedule,
                        principalTable: "ExamSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LecturterExamSchedules_Lecturers_IdLectuter",
                        column: x => x.IdLectuter,
                        principalTable: "Lecturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4906), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4926), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4928), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4933), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4934), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4935), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4938), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Unspecified).AddTicks(4948), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4818), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4846), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4849), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4749), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4754), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4986), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4991), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4877), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 12, 4, 4, 20, 36, 376, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_SubjectId_ClassId",
                table: "ExamStorage",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_SubjectId_ClassId",
                table: "ExaminationRoomDetail",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_IdBlock_IdSemester",
                table: "ExamSchedules",
                columns: new[] { "IdBlock", "IdSemester" });

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_IdShift",
                table: "ExamSchedules",
                column: "IdShift");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_IdTrainingFacility",
                table: "ExamSchedules",
                column: "IdTrainingFacility");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSchedules_SubjectId_ClassId",
                table: "ExamSchedules",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_LecturterExamSchedules_IdExamSchedule",
                table: "LecturterExamSchedules",
                column: "IdExamSchedule");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectClassUP_SubjectId_ClassId",
                table: "ExaminationRoomDetail",
                columns: new[] { "SubjectId", "ClassId" },
                principalTable: "SubjectClassUP",
                principalColumns: new[] { "SubjectId", "ClassId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_SubjectClassUP_SubjectId_ClassId",
                table: "ExamStorage",
                columns: new[] { "SubjectId", "ClassId" },
                principalTable: "SubjectClassUP",
                principalColumns: new[] { "SubjectId", "ClassId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
