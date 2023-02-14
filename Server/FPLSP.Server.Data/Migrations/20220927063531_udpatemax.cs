using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class udpatemax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_LessonUP_LessonUPId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_SubjectClassUP_SubjectClassUPSubjectId_SubjectClassUPClassId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_UserSignIn_UserSignInId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_LessonUPId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_SubjectClassUPSubjectId_SubjectClassUPClassId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_UserSignInId",
                table: "HomeWork");

            migrationBuilder.DropColumn(
                name: "LessonUPId",
                table: "HomeWork");

            migrationBuilder.DropColumn(
                name: "SubjectClassUPClassId",
                table: "HomeWork");

            migrationBuilder.DropColumn(
                name: "SubjectClassUPSubjectId",
                table: "HomeWork");

            migrationBuilder.DropColumn(
                name: "UserSignInId",
                table: "HomeWork");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "HomeWork",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1274), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1285), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1286), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1289), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1291), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1294), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1211) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1214), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1164), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1190), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1240), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1243), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1242), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 9, 27, 13, 35, 30, 594, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_IdLesson",
                table: "HomeWork",
                column: "IdLesson");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_IdSubject_IdClass",
                table: "HomeWork",
                columns: new[] { "IdSubject", "IdClass" });

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_IdUser",
                table: "HomeWork",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_LessonUP_IdLesson",
                table: "HomeWork",
                column: "IdLesson",
                principalTable: "LessonUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_SubjectClassUP_IdSubject_IdClass",
                table: "HomeWork",
                columns: new[] { "IdSubject", "IdClass" },
                principalTable: "SubjectClassUP",
                principalColumns: new[] { "SubjectId", "ClassId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_UserSignIn_IdUser",
                table: "HomeWork",
                column: "IdUser",
                principalTable: "UserSignIn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_LessonUP_IdLesson",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_SubjectClassUP_IdSubject_IdClass",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_UserSignIn_IdUser",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_IdLesson",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_IdSubject_IdClass",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_IdUser",
                table: "HomeWork");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUser",
                table: "HomeWork",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LessonUPId",
                table: "HomeWork",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectClassUPClassId",
                table: "HomeWork",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectClassUPSubjectId",
                table: "HomeWork",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UserSignInId",
                table: "HomeWork",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7936), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7946), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7947), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7952), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7953), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7955), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Unspecified).AddTicks(7957), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7882), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7885), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7888), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7839), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7854), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7978), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7985), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7989), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7911), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7911), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7914), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7917), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7916), new DateTime(2022, 9, 27, 13, 31, 8, 957, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_LessonUPId",
                table: "HomeWork",
                column: "LessonUPId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_SubjectClassUPSubjectId_SubjectClassUPClassId",
                table: "HomeWork",
                columns: new[] { "SubjectClassUPSubjectId", "SubjectClassUPClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_UserSignInId",
                table: "HomeWork",
                column: "UserSignInId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_LessonUP_LessonUPId",
                table: "HomeWork",
                column: "LessonUPId",
                principalTable: "LessonUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_SubjectClassUP_SubjectClassUPSubjectId_SubjectClassUPClassId",
                table: "HomeWork",
                columns: new[] { "SubjectClassUPSubjectId", "SubjectClassUPClassId" },
                principalTable: "SubjectClassUP",
                principalColumns: new[] { "SubjectId", "ClassId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_UserSignIn_UserSignInId",
                table: "HomeWork",
                column: "UserSignInId",
                principalTable: "UserSignIn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
