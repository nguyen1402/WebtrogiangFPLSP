using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class thuyenthemcaphe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_SubjectUPId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomDetail_SubjectUPId",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropColumn(
                name: "SubjectUPId",
                table: "ExaminationRoomDetail");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9438), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9452), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9453), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9456), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9457), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9458), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9461), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9462), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Unspecified).AddTicks(9470), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9355), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9323), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9517), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9525), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 12, 9, 20, 51, 32, 44, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_IdSubject",
                table: "ExaminationRoomDetail",
                column: "IdSubject");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_IdSubject",
                table: "ExaminationRoomDetail",
                column: "IdSubject",
                principalTable: "SubjectUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_IdSubject",
                table: "ExaminationRoomDetail");

            migrationBuilder.DropIndex(
                name: "IX_ExaminationRoomDetail_IdSubject",
                table: "ExaminationRoomDetail");

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectUPId",
                table: "ExaminationRoomDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2089), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2101), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2106), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2107), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(1984), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2001), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2134), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2143), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2147), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2053), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2056), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2055), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2061), new DateTime(2022, 12, 9, 13, 9, 44, 476, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.CreateIndex(
                name: "IX_ExaminationRoomDetail_SubjectUPId",
                table: "ExaminationRoomDetail",
                column: "SubjectUPId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExaminationRoomDetail_SubjectUP_SubjectUPId",
                table: "ExaminationRoomDetail",
                column: "SubjectUPId",
                principalTable: "SubjectUP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
