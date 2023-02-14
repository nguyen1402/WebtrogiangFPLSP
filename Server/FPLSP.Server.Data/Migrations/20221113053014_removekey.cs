using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class removekey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TeachingSchedule_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "SemesterBlockIdBlock",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "SemesterBlockIdSemester",
                table: "TeachingSchedule");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(467), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(652), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(657), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_IdBlock_IdSemester",
                table: "TeachingSchedule",
                columns: new[] { "IdBlock", "IdSemester" });

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_IdBlock_IdSemester",
                table: "TeachingSchedule",
                columns: new[] { "IdBlock", "IdSemester" },
                principalTable: "SemesterBlock",
                principalColumns: new[] { "IdBlock", "IdSemester" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_IdBlock_IdSemester",
                table: "TeachingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TeachingSchedule_IdBlock_IdSemester",
                table: "TeachingSchedule");

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

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingSchedule_SemesterBlock_SemesterBlockIdBlock_SemesterBlockIdSemester",
                table: "TeachingSchedule",
                columns: new[] { "SemesterBlockIdBlock", "SemesterBlockIdSemester" },
                principalTable: "SemesterBlock",
                principalColumns: new[] { "IdBlock", "IdSemester" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
