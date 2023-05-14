using bugops.Common;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bugops.Migrations {
    /// <inheritdoc />
    public partial class SeedAspNetUserRoles : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, Constants.Roles.Administrator, Constants.Roles.Administrator.ToUpper() },
                    { "2", null, Constants.Roles.Developer, Constants.Roles.Developer.ToUpper() },
                    { "3", null, Constants.Roles.User, Constants.Roles.User.ToUpper() },
                    { "4", null, Constants.Roles.Demo, Constants.Roles.Demo.ToUpper() }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "88cd6f2e-3c12-4a39-b6ed-bcc4a134595d", "administrator@example.com", true, "Administrator", "Administrator", false, null, "ADMINISTRATOR@EXAMPLE.COM", "ADMINISTRATOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWcCbVRflXDD9rS6v+np63653kvkt6JzJWPqpHhZPHuFNC05Unnm4PRQGRAYEz1KQ==", null, false, "c59d4051-8e9b-46a9-b80d-2e733910da6f", false, "administrator@example.com" },
                    { "2", 0, "3655506d-9605-4006-bfc8-7e536a2ff4d6", "developer@example.com", true, "Developer", "Developer", false, null, "DEVELOPER@EXAMPLE.COM", "DEVELOPER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWcCbVRflXDD9rS6v+np63653kvkt6JzJWPqpHhZPHuFNC05Unnm4PRQGRAYEz1KQ==", null, false, "dde8d28d-f894-4de8-a1ff-dff9140da5a7", false, "developer@example.com" },
                    { "3", 0, "2ee96690-7851-4aea-84d3-b0503037101d", "user@example.com", true, "User", "User", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWcCbVRflXDD9rS6v+np63653kvkt6JzJWPqpHhZPHuFNC05Unnm4PRQGRAYEz1KQ==", null, false, "270781ab-0fd8-43a8-84de-85c46464dc75", false, "user@example.com" },
                    { "4", 0, "dbe73d72-251f-44ff-8a93-ec2581fe4500", "demo@example.com", true, "Demo", "Demo", false, null, "DEMO@EXAMPLE.COM", "DEMO@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDWcCbVRflXDD9rS6v+np63653kvkt6JzJWPqpHhZPHuFNC05Unnm4PRQGRAYEz1KQ==", null, false, "51420608-3bc0-471a-9a60-e153635f4eee", false, "demo@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
