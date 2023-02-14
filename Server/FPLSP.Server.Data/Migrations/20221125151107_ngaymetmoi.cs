using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class ngaymetmoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "TeachingSchedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Remote",
                table: "TeachingSchedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4309), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4323), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4324), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4327), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4328), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4331), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Unspecified).AddTicks(4340), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4229), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4251), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4253), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4185), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4202), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4207), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4381), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4385), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4279), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4283), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4282), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4285), new DateTime(2022, 11, 25, 22, 11, 5, 753, DateTimeKind.Local).AddTicks(4284) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "Remote",
                table: "TeachingSchedule");

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
    }
}
