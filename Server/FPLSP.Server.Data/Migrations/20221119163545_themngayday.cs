using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class themngayday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TeachingDay",
                table: "TeachingSchedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3030), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3048), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3052), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3053), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Unspecified).AddTicks(3063), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2946), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2903), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2908), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3101), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2973), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2973), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2976), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2976), new DateTime(2022, 11, 19, 23, 35, 44, 694, DateTimeKind.Local).AddTicks(2975) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeachingDay",
                table: "TeachingSchedule");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1036), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1048), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1049), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1053), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1054), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1058), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Unspecified).AddTicks(1063), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(963), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(974), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(977), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(921), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(935), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(941), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1112), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1121), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1002), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1001), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1008), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1008), new DateTime(2022, 11, 18, 17, 55, 40, 595, DateTimeKind.Local).AddTicks(1007) });
        }
    }
}
