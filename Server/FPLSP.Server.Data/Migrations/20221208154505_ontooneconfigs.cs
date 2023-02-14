using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class ontooneconfigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5399), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5426), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5432), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5435), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5440), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Unspecified).AddTicks(5453), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5014), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5046), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4968), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5517), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5525), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5531), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5341), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 12, 8, 22, 45, 4, 151, DateTimeKind.Local).AddTicks(5347) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
