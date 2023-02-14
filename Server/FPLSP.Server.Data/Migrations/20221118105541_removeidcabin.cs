using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class removeidcabin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingRequest_Cabin_IdCabin",
                table: "BookingRequest");

            migrationBuilder.DropIndex(
                name: "IX_BookingRequest_IdCabin",
                table: "BookingRequest");

            migrationBuilder.DropColumn(
                name: "IdCabin",
                table: "BookingRequest");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdCabin",
                table: "BookingRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingRequest_IdCabin",
                table: "BookingRequest",
                column: "IdCabin");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingRequest_Cabin_IdCabin",
                table: "BookingRequest",
                column: "IdCabin",
                principalTable: "Cabin",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
