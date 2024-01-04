using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class SeedDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventID", "Date", "Description", "DurationInHours", "InviteByEmail", "Location", "OtherDetails", "StartTime", "Title", "Type", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "laura@gmail.com", "India", "", "09:00", "Node Js", "Public", 1 },
                    { 15, new DateTime(2015, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, "arturo@yahoo.com,anmol.baroliya@nagarro.com", "Shahdara", "", "21:00", "Memorial Show", "Private", 3 },
                    { 14, new DateTime(2016, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, "", "Ghaziabad", "", "14:00", "Year Book", "Public", 8 },
                    { 13, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "carson@gmail.com", "New Delhi", "", "08:00", "Online Quiz", "Private", 8 },
                    { 12, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, "yanli@rediff.com,arturo@yahoo.com", "Gurgaon", "", "05:00", "Tech Fest", "Public", 7 },
                    { 10, new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "We’ve received demand to host online workshop.", 1, "", "California", "In response to this demand, A.I. For Anyone is excited to host a Learn AI in 60 Minutes virtual workshop in partnership with the Mark Cuban Foundation.", "06:00", "Learn AI In 60 Minutes", "Public", 8 },
                    { 9, new DateTime(2017, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "nino.olivetto@gmail.com", "Texas,USA", "", "01:00", "Propaganda Live Tour", "Private", 4 },
                    { 11, new DateTime(2020, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "laura@gmail.com,anmol.baroliya@nagarro.com", "Mumbai", "", "04:00", "Learn Python", "Public", 7 },
                    { 7, new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, "", "Sydeny,Australia", "", "18:00", "Easter Concert", "Private", 3 },
                    { 6, new DateTime(2020, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, "yanli@rediff.com", "New York", "", "16:00", "The Doors Alive", "Private", 8 },
                    { 5, new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, "arturo@yahoo.com", "Germany", "", "10:00", "Josh Clapham Memorial Show", "Private", 3 },
                    { 4, new DateTime(2020, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, "", "London", "", "11:00", "Altered Images", "Public", 2 },
                    { 3, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, "carson@gmail.com,anmol.baroliya@nagarro.com", "New Delhi", "", "08:00", "Level Up", "Private", 2 },
                    { 2, new DateTime(2017, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, "yanli@rediff.com,arturo@yahoo.com", "America", "", "12:00", "Java Quiz", "Public", 1 },
                    { 8, new DateTime(2019, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "anmol.baroliya@nagarro.com", "Delhi", "", "13:00", "Mental Health Conference", "Public", 3 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "Email", "FullName", "Password" },
                values: new object[,]
                {
                    { 6, "nino.olivetto@gmail.com", "Nino Olivetto", "nino@!" },
                    { 1, "carson@gmail.com", "Carson Alexander", "carson@" },
                    { 2, "meredith@gmail.com", "Meredith Alonso", "meredith!" },
                    { 3, "arturo@yahoo.com", "Arturo Anand", "arturo@" },
                    { 4, "yanli@rediff.com", "Yan Li", "yanli#" },
                    { 5, "peggy@gmail.com", "Peggy Justice", "peggy!" },
                    { 7, "laura@gmail.com", "Laura Norman", "laura@" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentID", "Comments", "DateTime", "EventID" },
                values: new object[,]
                {
                    { 1, "Nice Event...!", new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "I like it...!", new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Thanks for it.", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Superb Event", new DateTime(2020, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, "Great...", new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Nice", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "Gazab..(`.`)", new DateTime(2019, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 8, "Cool Event", new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, "Waiting for it...", new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 9, "You are Great", new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 12, "Nice Event...!", new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 13, "Very interesting", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 11, "Super cool", new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 14, "Nice Event...!", new DateTime(2019, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 15, "Cool", new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "EventID",
                keyValue: 9);
        }
    }
}
