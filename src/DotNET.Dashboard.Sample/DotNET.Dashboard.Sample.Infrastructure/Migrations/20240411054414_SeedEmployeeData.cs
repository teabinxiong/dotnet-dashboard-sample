using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNET.Dashboard.Sample.Infrastructure.Migrations
{
    public partial class SeedEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeJobTitles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1L, "Sales Manager", "SM" },
                    { 2L, "Team Leader", "TL" },
                    { 3L, "Sales Rep", "SR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "EmployeeJobTitleId", "FirstName", "Gender", "ImagePath", "LastName", "ReportToEmpId" },
                values: new object[,]
                {
                    { 1L, new DateTime(1974, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.jones@oexl.com", 1, "Bob", "Male", "/Images/Profile/BobJones.jpg", "Jones", null },
                    { 2L, new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jenny.marks@oexl.com", 2, "Jenny", "Female", "/Images/Profile/JennyMarks.jpg", "Marks", 1L },
                    { 3L, new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.andrews@oexl.com", 2, "Henry", "Male", "/Images/Profile/HenryAndrews.jpg", "Andrews", 1L },
                    { 4L, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.jameson@oexl.com", 2, "John", "Male", "/Images/Profile/JohnJameson.jpg", "Jameson", 1L },
                    { 5L, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.robinson@oexl.com", 3, "Noah", "Male", "/Images/Profile/NoahRobinson.jpg", "Robinson", 2L },
                    { 6L, new DateTime(1993, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "elijah.hamilton@oexl.com", 3, "Elijah", "Male", "/Images/Profile/ElijahHamilton.jpg", "Hamilton", 2L },
                    { 7L, new DateTime(1992, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "jamie.fisher@oexl.com", 3, "Jamie", "Male", "/Images/Profile/JamieFisher.jpg", "Fisher", 2L },
                    { 8L, new DateTime(1990, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.mills@oexl.com", 3, "Olivia", "Female", "/Images/Profile/OliviaMills.jpg", "Mills", 3L },
                    { 9L, new DateTime(1993, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.lucas@oexl.com", 3, "Benjamin", "Male", "/Images/Profile/BenjaminLucas.jpg", "Lucas", 3L },
                    { 10L, new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarah.henderson@oexl.com", 3, "Sarah", "Female", "/Images/Profile/SarahHenderson.jpg", "Henderson", 3L },
                    { 11L, new DateTime(1995, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.lee@oexl.com", 3, "Emma", "Female", "/Images/Profile/EmmaLee.jpg", "Lee", 4L },
                    { 12L, new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.williams@oexl.com", 3, "Ava", "Female", "/Images/Profile/AvaWilliams.jpg", "Williams", 4L },
                    { 13L, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "angela.moore@oexl.com", 3, "Angela", "Female", "/Images/Profile/AngelaMoore.jpg", "Moore", 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EmployeeJobTitles",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13L);
        }
    }
}
