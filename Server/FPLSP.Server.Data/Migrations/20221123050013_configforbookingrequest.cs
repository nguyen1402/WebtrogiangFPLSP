using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class configforbookingrequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContenOfFeedBack",
                table: "BookingRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "BookingRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FeedBackTime",
                table: "BookingRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "BookingRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9098), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9108), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9112), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9113), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9117), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Unspecified).AddTicks(9118), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9037), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9042), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9147), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9069), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9072), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 11, 23, 12, 0, 12, 26, DateTimeKind.Local).AddTicks(9074) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContenOfFeedBack",
                table: "BookingRequest");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "BookingRequest");

            migrationBuilder.DropColumn(
                name: "FeedBackTime",
                table: "BookingRequest");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "BookingRequest");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2286), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2288), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2291), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2296), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2199), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2155), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2172), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2176), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2332), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2338), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2341), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2242), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2248), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2251), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2251), new DateTime(2022, 11, 23, 4, 30, 32, 132, DateTimeKind.Local).AddTicks(2250) });
        }
    }
}
