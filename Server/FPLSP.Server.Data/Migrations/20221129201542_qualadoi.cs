using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class qualadoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin");

            migrationBuilder.AddColumn<bool>(
                name: "IsEditing",
                table: "TeachingSchedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ResourceLinkUP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ResourceLinkCP",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "BookingCabin",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "BookingCabin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin",
                columns: new[] { "Id", "SubjectId", "ClassId", "IdCabin", "IdShift" });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1927), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1941), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1942), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1946), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Unspecified).AddTicks(1952), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1846), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1973), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1978), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1903), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1902), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 11, 30, 3, 15, 41, 42, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCabin_SubjectId_ClassId",
                table: "BookingCabin",
                columns: new[] { "SubjectId", "ClassId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin");

            migrationBuilder.DropIndex(
                name: "IX_BookingCabin_SubjectId_ClassId",
                table: "BookingCabin");

            migrationBuilder.DropColumn(
                name: "IsEditing",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ResourceLinkUP");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ResourceLinkCP");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookingCabin");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "BookingCabin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingCabin",
                table: "BookingCabin",
                columns: new[] { "SubjectId", "ClassId", "IdCabin", "IdShift" });

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
    }
}
