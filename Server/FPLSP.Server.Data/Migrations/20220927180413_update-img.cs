using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class updateimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SpecializedUP",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "SpecializedCP",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5719), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5735), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5740), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5741), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Unspecified).AddTicks(5742), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5662), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5665), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5668), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5615), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5636), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "SpecializedCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                column: "Image",
                value: "OKE.PNG");

            migrationBuilder.UpdateData(
                table: "SpecializedCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                column: "Image",
                value: "OKE.PNG");

            migrationBuilder.UpdateData(
                table: "SpecializedCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                column: "Image",
                value: "OKE.PNG");

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5766), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5772), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5776), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5693), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5692), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5696), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5699), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5699), new DateTime(2022, 9, 28, 1, 4, 12, 101, DateTimeKind.Local).AddTicks(5698) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "SpecializedUP");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "SpecializedCP");

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
        }
    }
}
