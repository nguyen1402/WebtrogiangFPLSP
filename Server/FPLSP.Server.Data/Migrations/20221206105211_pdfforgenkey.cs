using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class pdfforgenkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_UserSignIn_UserSignInId",
                table: "ExamStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_UserSignInId",
                table: "ExamStorage");

            migrationBuilder.DropColumn(
                name: "UserSignInId",
                table: "ExamStorage");

            migrationBuilder.AlterColumn<string>(
                name: "IdUserUpLoad",
                table: "ExamStorage",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3515), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3540), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3618), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3621), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3624), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3632), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3634), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Unspecified).AddTicks(3649), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3334), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3202), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3732), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 12, 6, 17, 52, 10, 590, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_IdUserUpLoad",
                table: "ExamStorage",
                column: "IdUserUpLoad");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_UserSignIn_IdUserUpLoad",
                table: "ExamStorage",
                column: "IdUserUpLoad",
                principalTable: "UserSignIn",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamStorage_UserSignIn_IdUserUpLoad",
                table: "ExamStorage");

            migrationBuilder.DropIndex(
                name: "IX_ExamStorage_IdUserUpLoad",
                table: "ExamStorage");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUserUpLoad",
                table: "ExamStorage",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserSignInId",
                table: "ExamStorage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6177), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6234), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6235), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6243), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6245), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6248), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6256), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6258), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Unspecified).AddTicks(6279), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5981), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6041), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5915), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6358), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6371), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6381), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6122), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6121), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 12, 6, 17, 33, 51, 726, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.CreateIndex(
                name: "IX_ExamStorage_UserSignInId",
                table: "ExamStorage",
                column: "UserSignInId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamStorage_UserSignIn_UserSignInId",
                table: "ExamStorage",
                column: "UserSignInId",
                principalTable: "UserSignIn",
                principalColumn: "Id");
        }
    }
}
