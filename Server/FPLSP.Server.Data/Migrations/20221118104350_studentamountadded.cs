using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class studentamountadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentAmount",
                table: "SubjectClassUP",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5357), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5375), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5376), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5377), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5380), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Unspecified).AddTicks(5389), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5274), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5298), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5301), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5228), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5243), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5248), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5508), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5514), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5518), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5327), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5327), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5333), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5332), new DateTime(2022, 11, 18, 17, 43, 49, 802, DateTimeKind.Local).AddTicks(5332) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentAmount",
                table: "SubjectClassUP");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8941), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8955), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8956), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8960), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8961), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8965), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Unspecified).AddTicks(8973), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8865), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8887), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8819), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8836), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8841), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9024), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9028), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918), new DateTime(2022, 11, 18, 17, 40, 21, 333, DateTimeKind.Local).AddTicks(8918) });
        }
    }
}
