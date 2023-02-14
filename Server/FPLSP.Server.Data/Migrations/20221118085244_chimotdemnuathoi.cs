using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPLSP.Server.Data.Migrations
{
    public partial class chimotdemnuathoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.AddColumn<Guid>(
                name: "IdTrainingFacility",
                table: "UserSignIn",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("169A0425-7E5A-4057-9748-32F1CF3C1479"));

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6300), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6311), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6314), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6318), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Unspecified).AddTicks(6319), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6181), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6184), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6186), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6155), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6159), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6339), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6344), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6348), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6276), new DateTime(2022, 11, 18, 15, 52, 43, 130, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.CreateIndex(
                name: "IX_UserSignIn_IdTrainingFacility",
                table: "UserSignIn",
                column: "IdTrainingFacility");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSignIn_TrainingFacilitiesCP_IdTrainingFacility",
                table: "UserSignIn",
                column: "IdTrainingFacility",
                principalTable: "TrainingFacilitiesCP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSignIn_TrainingFacilitiesCP_IdTrainingFacility",
                table: "UserSignIn");

            migrationBuilder.DropIndex(
                name: "IX_UserSignIn_IdTrainingFacility",
                table: "UserSignIn");

            migrationBuilder.DropColumn(
                name: "IdTrainingFacility",
                table: "UserSignIn");

            migrationBuilder.AddColumn<int>(
                name: "StudentAmount",
                table: "ClassUp",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(606), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(622), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(626), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(627), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ContentOfExamCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedTime", "DateStarted", "EndDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(630), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Unspecified).AddTicks(631), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "ExamLinkCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "ExpirationDate" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(467), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(481), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "Dob", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(652), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(657), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "StudentCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "DateOfBirth", "IssuedOn" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(537), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("269a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "SubjectCP",
                keyColumn: "Id",
                keyValue: new Guid("369a0425-7e5a-4057-9748-32f1cf3c1479"),
                columns: new[] { "CreatedDay", "EndDay", "StartDay" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 11, 13, 12, 30, 13, 331, DateTimeKind.Local).AddTicks(542) });
        }
    }
}
