﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class addrefresttokentable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Link",
                value: "www.github.com/Beceapa.Sandalci61");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Link",
                value: "www.github.com/Batu.Akyurek");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Link",
                value: "www.github.com/Bengi_Topcuoglu");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Link",
                value: "www.github.com/Buzac_Karabulut99");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Link",
                value: "www.github.com/Budunlu.Kurutluoglu89");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Link",
                value: "www.github.com/Budus_Sarioglu");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Link",
                value: "www.github.com/Gokboru_Limoncuoglu51");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Link",
                value: "www.github.com/Erdem.Sozeri62");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Link",
                value: "www.github.com/Barkdurdu14");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Link",
                value: "www.github.com/Bucur.Sozeri38");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Azmi43@hotmail.com", "Azmi", "Kurutluoğlu", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ummiye.Ercetin@hotmail.com", "Ümmiye", "Erçetin", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Gulriz.Kocyigit@yahoo.com", "Gülriz", "Koçyiğit", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Halit.Avan@gmail.com", "Halit", "Avan", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { "Kasim_Tanrikulu96@hotmail.com", "Kasım", "Tanrıkulu", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 }, false });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Yildirim70@gmail.com", "Yıldırım", "Poçan", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Habil34@hotmail.com", "Habil", "Elmastaşoğlu", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { "Ebuzer.Babaoglu57@yahoo.com", "Ebuzer", "Babaoğlu", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 }, false });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Adel_Eronat36@yahoo.com", "Adel", "Eronat", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Remzi.Aydan60@yahoo.com", "Remzi", "Aydan", new byte[] { 125, 248, 108, 240, 150, 13, 102, 91, 226, 28, 222, 181, 0, 126, 8, 106, 124, 25, 24, 225, 178, 23, 175, 114, 126, 236, 70, 62, 18, 60, 150, 190, 241, 215, 96, 82, 69, 150, 150, 117, 106, 111, 87, 246, 193, 65, 154, 156, 155, 208, 8, 173, 76, 173, 1, 202, 154, 104, 217, 126, 235, 113, 107, 146, 53, 91, 23, 212, 226, 165, 85, 16, 134, 83, 173, 152, 91, 160, 50, 252, 110, 59, 147, 182, 22, 200, 49, 40, 202, 64, 120, 117, 124, 129, 96, 229, 79, 109, 46, 84, 58, 117, 253, 151, 182, 97, 180, 168, 20, 250, 99, 136, 89, 51, 207, 199, 249, 210, 155, 165, 233, 107, 229, 122, 40, 37, 203, 203 }, new byte[] { 25, 38, 34, 133, 34, 104, 95, 160, 62, 86, 41, 153, 39, 220, 7, 42, 135, 0, 245, 106, 115, 147, 64, 132, 40, 130, 97, 156, 139, 2, 137, 135, 210, 158, 23, 177, 212, 223, 106, 153, 123, 153, 246, 120, 49, 68, 215, 142, 213, 252, 0, 41, 7, 187, 186, 18, 26, 93, 100, 173, 33, 1, 212, 60 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Link",
                value: "www.github.com/Busulgan41");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Link",
                value: "www.github.com/Cagan.Cagiran");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Link",
                value: "www.github.com/Gelincik.Korol");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Link",
                value: "www.github.com/Artiinal90");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Link",
                value: "www.github.com/Abaka.Avan");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Link",
                value: "www.github.com/Askin.Yorulmaz");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Link",
                value: "www.github.com/Belgi66");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Link",
                value: "www.github.com/Butuk_Kaplangi");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Link",
                value: "www.github.com/Karaca61");

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 10,
                column: "Link",
                value: "www.github.com/Bokde54");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Anise47@yahoo.com", "Anise", "Aşıkoğlu", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Ezrak25@hotmail.com", "Ezrak", "Solmaz", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Perver.Ozgorkey@gmail.com", "Perver", "Özgörkey", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Taskin.Sadiklar@yahoo.com", "Taşkın", "Sadıklar", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { "Selda_Denkel@yahoo.com", "Selda", "Denkel", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 }, true });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Eren.Erbay29@hotmail.com", "Eren", "Erbay", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Memduh.Cevik@gmail.com", "Memduh", "Çevik", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[] { "Yasar.Dagdas@hotmail.com", "Yaşar", "Dağdaş", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 }, true });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Oguzhan_Ilicali82@hotmail.com", "Oğuzhan", "Ilıcalı", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { "Meric_Erkekli@gmail.com", "Meriç", "Erkekli", new byte[] { 191, 98, 181, 194, 230, 43, 0, 3, 200, 89, 210, 159, 105, 146, 247, 185, 165, 120, 244, 248, 194, 27, 104, 41, 152, 30, 62, 96, 180, 214, 203, 220, 203, 254, 155, 71, 170, 113, 41, 45, 42, 170, 32, 176, 20, 217, 48, 87, 237, 191, 59, 167, 202, 94, 139, 88, 52, 23, 126, 171, 236, 157, 243, 122, 148, 137, 206, 57, 229, 219, 149, 227, 45, 153, 236, 92, 160, 116, 26, 138, 205, 141, 194, 15, 145, 185, 231, 136, 102, 255, 4, 88, 247, 240, 116, 82, 36, 130, 16, 231, 2, 32, 109, 223, 28, 162, 180, 35, 173, 62, 121, 3, 153, 235, 231, 104, 173, 177, 160, 253, 121, 169, 125, 235, 32, 53, 176, 166 }, new byte[] { 197, 167, 146, 129, 161, 211, 255, 106, 175, 35, 38, 119, 217, 254, 240, 219, 93, 216, 17, 55, 245, 103, 158, 109, 102, 200, 28, 100, 109, 235, 160, 110, 51, 196, 4, 146, 141, 185, 98, 202, 23, 191, 157, 183, 170, 114, 32, 8, 32, 84, 112, 174, 217, 253, 154, 158, 231, 143, 102, 191, 228, 120, 85, 141 } });
        }
    }
}