using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class updatere : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdTrainingFacility",
                table: "TeachingSchedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("169A0425-7E5A-4057-9748-32F1CF3C1479"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdTrainingFacility",
                table: "Cabin",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("169A0425-7E5A-4057-9748-32F1CF3C1479"));

            migrationBuilder.AlterColumn<byte[]>(
                name: "CheckinImage",
                table: "BookingCabin",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_IdTrainingFacility",
                table: "TeachingSchedule",
                column: "IdTrainingFacility");

            migrationBuilder.CreateIndex(
                name: "IX_Cabin_IdTrainingFacility",
                table: "Cabin",
                column: "IdTrainingFacility");

            migrationBuilder.AddForeignKey(
                name: "FK_Cabin_TrainingFacilitiesCP_IdTrainingFacility",
                table: "Cabin",
                column: "IdTrainingFacility",
                principalTable: "TrainingFacilitiesCP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeachingSchedule_TrainingFacilitiesCP_IdTrainingFacility",
                table: "TeachingSchedule",
                column: "IdTrainingFacility",
                principalTable: "TrainingFacilitiesCP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cabin_TrainingFacilitiesCP_IdTrainingFacility",
                table: "Cabin");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachingSchedule_TrainingFacilitiesCP_IdTrainingFacility",
                table: "TeachingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_TeachingSchedule_IdTrainingFacility",
                table: "TeachingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_Cabin_IdTrainingFacility",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "IdTrainingFacility",
                table: "TeachingSchedule");

            migrationBuilder.DropColumn(
                name: "IdTrainingFacility",
                table: "Cabin");

            migrationBuilder.AlterColumn<byte[]>(
                name: "CheckinImage",
                table: "BookingCabin",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

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
    }
}
