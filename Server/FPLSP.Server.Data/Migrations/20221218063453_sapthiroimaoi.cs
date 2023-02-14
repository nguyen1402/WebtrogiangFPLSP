using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class sapthiroimaoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "SupervisorExamRoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "SupervisorExamRoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7105), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7121), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7126), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7128), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6966), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6985), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6988), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6939), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6943), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7186), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7192), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7195), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7069), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7069), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7072), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7072), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7075), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7074), new DateTime(2022, 12, 18, 13, 34, 52, 107, DateTimeKind.Local).AddTicks(7074) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "SupervisorExamRoom");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "SupervisorExamRoom");

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
    }
}
