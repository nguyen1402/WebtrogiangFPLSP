using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class happybirthdaytome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_ShiftOfCabin_IdShift",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_StudentUP_IdStudent",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropTable(
                name: "ExaminationRoomStorage");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "ExamDay",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "IdShift",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "IdStudent",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "ExamDay",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "IdShift",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "ExamDay",
                table: "ExaminationRoomDetail");

            migrationBuilder.RenameColumn(
                name: "IdShift",
                table: "ExaminationRoomDetail",
                newName: "SubjectUPId");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationRoomDetail_IdShift",
                table: "ExaminationRoomDetail",
                newName: "IX_ExaminationRoomDetail_SubjectUPId");

            migrationBuilder.AddColumn<string>(
                name: "SecretKey",
                table: "SupervisorExamRoom",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "OnlineExamRoom",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecretKey",
                table: "OnlineExamRoom",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SecretKey",
                table: "ExaminationRoomDetail",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "ExaminationRoomDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IdSubject",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "ExaminationRoomDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "IdLecturter", "SecretKey", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom",
                columns: new[] { "IdUser", "SecretKey", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail",
                columns: new[] { "SecretKey", "IdExaminationRoom" });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3707), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3725), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3728), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3730), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3733), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3653), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3586), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3605), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3826), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3682), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 12, 8, 21, 48, 59, 106, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorExamRoom_SecretKey_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "SecretKey", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineExamRoom_SecretKey_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "SecretKey", "IdExaminationRoom" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_SubjectUPId",
                table: "ExaminationRoomDetail",
                column: "SubjectUPId",
                principalTable: "SubjectUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "SecretKey", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "SecretKey", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_UserSignIn_IdUser",
                table: "OnlineExamRoom",
                column: "IdUser",
                principalTable: "UserSignIn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "SecretKey", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "SecretKey", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_SubjectUPId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlineExamRoom_UserSignIn_IdUser",
                table: "OnlineExamRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_SupervisorExamRoom_SecretKey_IdExaminationRoom",
                table: "SupervisorExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropIndex(
                name: "IX_OnlineExamRoom_SecretKey_IdExaminationRoom",
                table: "OnlineExamRoom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "SecretKey",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "SecretKey",
                table: "OnlineExamRoom");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "IdSubject",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "ExaminationRoomDetail");

            migrationBuilder.RenameColumn(
                name: "SubjectUPId",
                table: "ExaminationRoomDetail",
                newName: "IdShift");

            migrationBuilder.RenameIndex(
                name: "IX_ExaminationRoomDetail_SubjectUPId",
                table: "ExaminationRoomDetail",
                newName: "IX_ExaminationRoomDetail_IdShift");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDay",
                table: "SupervisorExamRoom",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IdShift",
                table: "SupervisorExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdStudent",
                table: "OnlineExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDay",
                table: "OnlineExamRoom",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IdShift",
                table: "OnlineExamRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "SecretKey",
                table: "ExaminationRoomDetail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDay",
                table: "ExaminationRoomDetail",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupervisorExamRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "IdLecturter", "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OnlineExamRoom",
                table: "OnlineExamRoom",
                columns: new[] { "IdStudent", "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExaminationRoomDetail",
                table: "ExaminationRoomDetail",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateTable(
                name: "ExaminationRoomStorage",
                columns: table => new
                {
                    IdExamFile = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExaminationRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexOfExaminationRoomStorage = table.Column<int>(type: "int", nullable: false),
                    IsMainFile = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationRoomStorage", x => new { x.IdExamFile, x.ExamDay, x.IdShift, x.IdExaminationRoom });
                    table.ForeignKey(
                        name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                        columns: x => new { x.ExamDay, x.IdShift, x.IdExaminationRoom },
                        principalTable: "ExaminationRoomDetail",
                        principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExaminationRoomStorage_ExamStorage_IdExamFile",
                        column: x => x.IdExamFile,
                        principalTable: "ExamStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3515), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3624), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3334), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3202), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3732), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineExamRoom_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_ShiftOfCabin_IdShift",
                table: "ExaminationRoomDetail",
                column: "IdShift",
                principalTable: "ShiftOfCabin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlineExamRoom_StudentUP_IdStudent",
                table: "OnlineExamRoom",
                column: "IdStudent",
                principalTable: "StudentUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "ExamDay", "IdShift", "IdExaminationRoom" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
