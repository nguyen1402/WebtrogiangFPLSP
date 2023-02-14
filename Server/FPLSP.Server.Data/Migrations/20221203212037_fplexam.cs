using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class fplexam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExaminationRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExaminationRoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexOfExaminationRoom = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdTrainingFacility = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExaminationRoom_TrainingFacilitiesCP_IdTrainingFacility",
                        column: x => x.IdTrainingFacility,
                        principalTable: "TrainingFacilitiesCP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamSchedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImportTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdAdminImport = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    IndexOfExamSchedule = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdBlock = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSemester = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTrainingFacility = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "ExamStorage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExamFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IndexOfExamStorageFile = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTimeOfExam = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamStorage_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationRoomDetail",
                columns: table => new
                {
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExaminationRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexOfExaminationRoomDetail = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationRoomDetail", x => new { x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom });
                    table.ForeignKey(
                        name: "FK_ExaminationRoomDetail_ExaminationRoom_IdExaminationRoom",
                        column: x => x.IdExaminationRoom,
                        principalTable: "ExaminationRoom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExaminationRoomDetail_ShiftOfCabin_IdShift",
                        column: x => x.IdShift,
                        principalTable: "ShiftOfCabin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExaminationRoomDetail_SubjectClassUP_SubjectId_ClassId",
                        columns: x => new { x.SubjectId, x.ClassId },
                        principalTable: "SubjectClassUP",
                        principalColumns: new[] { "SubjectId", "ClassId" },
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

            migrationBuilder.CreateTable(
                name: "ExaminationRoomStorage",
                columns: table => new
                {
                    IdExamFile = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExaminationRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexOfExaminationRoomStorage = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMainFile = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationRoomStorage", x => new { x.IdExamFile, x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom });
                    table.ForeignKey(
                        name: "FK_ExaminationRoomStorage_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                        columns: x => new { x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom },
                        principalTable: "ExaminationRoomDetail",
                        principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExaminationRoomStorage_ExamStorage_IdExamFile",
                        column: x => x.IdExamFile,
                        principalTable: "ExamStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineExamRoom",
                columns: table => new
                {
                    IdStudent = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExaminationRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JoinTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChekinImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LeaveTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IndexOfStudent = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineExamRoom", x => new { x.IdStudent, x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom });
                    table.ForeignKey(
                        name: "FK_OnlineExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                        columns: x => new { x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom },
                        principalTable: "ExaminationRoomDetail",
                        principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineExamRoom_StudentUP_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "StudentUP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupervisorExamRoom",
                columns: table => new
                {
                    IdLecturter = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamDay = table.Column<DateTime>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdShift = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdExaminationRoom = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsMainSupervisor = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupervisorExamRoom", x => new { x.IdLecturter, x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom });
                    table.ForeignKey(
                        name: "FK_SupervisorExamRoom_ExaminationRoomDetail_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                        columns: x => new { x.ExamDay, x.SubjectId, x.ClassId, x.IdShift, x.IdExaminationRoom },
                        principalTable: "ExaminationRoomDetail",
                        principalColumns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupervisorExamRoom_Lecturers_IdLecturter",
                        column: x => x.IdLecturter,
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
                name: "IX_ExaminationRoom_IdTrainingFacility",
                table: "ExaminationRoom",
                column: "IdTrainingFacility");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_IdExaminationRoom",
                table: "ExaminationRoomDetail",
                column: "IdExaminationRoom");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_IdShift",
                table: "ExaminationRoomDetail",
                column: "IdShift");

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_SubjectId_ClassId",
                table: "ExaminationRoomDetail",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomStorage_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "ExaminationRoomStorage",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

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
                name: "IX_ExamStorage_SubjectId_ClassId",
                table: "ExamStorage",
                columns: new[] { "SubjectId", "ClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_LecturterExamSchedules_IdExamSchedule",
                table: "LecturterExamSchedules",
                column: "IdExamSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "OnlineExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });

            migrationBuilder.CreateIndex(
                name: "IX_SupervisorExamRoom_ExamDay_SubjectId_ClassId_IdShift_IdExaminationRoom",
                table: "SupervisorExamRoom",
                columns: new[] { "ExamDay", "SubjectId", "ClassId", "IdShift", "IdExaminationRoom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExaminationRoomStorage");

            migrationBuilder.DropTable(
                name: "LecturterExamSchedules");

            migrationBuilder.DropTable(
                name: "OnlineExamRoom");

            migrationBuilder.DropTable(
                name: "SupervisorExamRoom");

            migrationBuilder.DropTable(
                name: "ExamStorage");

            migrationBuilder.DropTable(
                name: "ExamSchedules");

            migrationBuilder.DropTable(
                name: "ExaminationRoomDetail");

            migrationBuilder.DropTable(
                name: "ExaminationRoom");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8527), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8537), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8538), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8543), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8544), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8590), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Unspecified).AddTicks(8591), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8478), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8449), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8454), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8621), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8625), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8504), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8503), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8507), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8506), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8509), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8509), new DateTime(2022, 12, 1, 15, 0, 55, 698, DateTimeKind.Local).AddTicks(8508) });
        }
    }
}
