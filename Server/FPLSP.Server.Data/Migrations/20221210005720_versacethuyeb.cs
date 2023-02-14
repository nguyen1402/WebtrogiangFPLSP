using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class versacethuyeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "ExamStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_SecretKey_IdExaminationRoom",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "IdExaminationRoom",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "SecretKey",
                table: "ExamStorage");

            migrationBuilder.AddColumn<Guid>(
                name: "IdExamFile",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("EC31C10E-EC7D-4041-9EE0-4A60779AA4BE"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_IdExamFile",
                table: "ExaminationRoomDetail",
                column: "IdExamFile");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_ExamStorage_IdExamFile",
                table: "ExaminationRoomDetail",
                column: "IdExamFile",
                principalTable: "ExamStorage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_ExamStorage_IdExamFile",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomDetail_IdExamFile",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "IdExamFile",
                table: "ExaminationRoomDetail");

            migrationBuilder.AddColumn<Guid>(
                name: "IdExaminationRoom",
                table: "ExamStorage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "SecretKey",
                table: "ExamStorage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5046), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5060), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5067), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4989), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4992), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4936), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5122), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5127), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5131), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5021), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5021), new DateTime(2022, 12, 9, 22, 25, 50, 565, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_SecretKey_IdExaminationRoom",
                table: "ExamStorage",
                columns: new[] { "SecretKey", "IdExaminationRoom" },
                unique: true,
                filter: "[SecretKey] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_ExaminationRoomDetail_SecretKey_IdExaminationRoom",
                table: "ExamStorage",
                columns: new[] { "SecretKey", "IdExaminationRoom" },
                principalTable: "ExaminationRoomDetail",
                principalColumns: new[] { "SecretKey", "IdExaminationRoom" });
        }
    }
}
