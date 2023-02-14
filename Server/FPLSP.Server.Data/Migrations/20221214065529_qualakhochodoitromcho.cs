using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class qualakhochodoitromcho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHandlerRequest",
                table: "OnlineExamRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8223), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8224), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8227), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8228), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8229), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8232), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8232), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Unspecified).AddTicks(8233), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8150), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8153), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8105), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8126), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8131), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8263), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8273), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8181), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8184), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8183), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8186), new DateTime(2022, 12, 14, 13, 55, 28, 52, DateTimeKind.Local).AddTicks(8186) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHandlerRequest",
                table: "OnlineExamRoom");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(409), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(424), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(426), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(430), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(431), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(435), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Unspecified).AddTicks(441), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(211), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(229), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(234), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(478), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(484), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(373), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(372), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(376), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(379), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(378), new DateTime(2022, 12, 13, 9, 31, 25, 777, DateTimeKind.Local).AddTicks(378) });
        }
    }
}
