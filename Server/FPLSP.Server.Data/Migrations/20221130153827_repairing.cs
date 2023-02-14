using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class repairing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdLecturter",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("4759E27E-7C6B-4103-8369-BEC97C219EFA"));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7429), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7430), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7434), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7435), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7436), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7438), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7439), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Unspecified).AddTicks(7440), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7357), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7360), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7362), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7268), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7283), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7464), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7391), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7395), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7394), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7397), new DateTime(2022, 11, 30, 22, 38, 26, 104, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_IdLecturter",
                table: "TeachingSchedule",
                column: "IdLecturter");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingSchedule_Lecturers_IdLecturter",
                table: "TeachingSchedule",
                column: "IdLecturter",
                principalTable: "Lecturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeachingSchedule_Lecturers_IdLecturter",
                table: "TeachingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TeachingSchedule_IdLecturter",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "IdLecturter",
                table: "TeachingSchedule");

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
        }
    }
}
