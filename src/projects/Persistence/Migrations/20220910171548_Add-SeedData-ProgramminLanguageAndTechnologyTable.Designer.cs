﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220910171548_Add-SeedData-ProgramminLanguageAndTechnologyTable")]
    partial class AddSeedDataProgramminLanguageAndTechnologyTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Domain.Entities.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Esin10@yahoo.com",
                            FirstName = "Esin",
                            LastName = "Topçuoğlu",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        },
                        new
                        {
                            Id = 2,
                            Email = "Perihan_Akisik80@hotmail.com",
                            FirstName = "Perihan",
                            LastName = "Akışık",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            Email = "Tinas_Yesilkaya34@yahoo.com",
                            FirstName = "Tınas",
                            LastName = "Yeşilkaya",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Email = "Arin11@hotmail.com",
                            FirstName = "Arın",
                            LastName = "Karaduman",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        },
                        new
                        {
                            Id = 5,
                            Email = "Rustu72@gmail.com",
                            FirstName = "Rüştü",
                            LastName = "Kutlay",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            Email = "Kismet_Yalcin11@gmail.com",
                            FirstName = "Kısmet",
                            LastName = "Yalçın",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        },
                        new
                        {
                            Id = 7,
                            Email = "Mihriban_Corekci16@hotmail.com",
                            FirstName = "Mihriban",
                            LastName = "Çörekçi",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Email = "Erguner9@gmail.com",
                            FirstName = "Ergüner",
                            LastName = "Çapanoğlu",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        },
                        new
                        {
                            Id = 9,
                            Email = "Nevzat13@yahoo.com",
                            FirstName = "Nevzat",
                            LastName = "Sezek",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = true
                        },
                        new
                        {
                            Id = 10,
                            Email = "Vahdet33@hotmail.com",
                            FirstName = "Vahdet",
                            LastName = "Durak ",
                            PasswordHash = new byte[] { 81, 180, 156, 177, 67, 75, 23, 24, 98, 73, 140, 69, 218, 60, 225, 144, 208, 100, 253, 84, 20, 243, 39, 240, 230, 169, 90, 105, 169, 23, 194, 60, 120, 251, 206, 118, 159, 119, 88, 55, 112, 119, 122, 98, 159, 248, 98, 31, 41, 103, 181, 67, 219, 152, 111, 170, 51, 37, 167, 248, 198, 19, 11, 64, 228, 216, 15, 101, 142, 212, 129, 226, 161, 131, 227, 208, 4, 0, 215, 245, 38, 220, 238, 17, 195, 247, 64, 165, 200, 248, 215, 187, 105, 149, 131, 142, 187, 176, 100, 253, 22, 150, 134, 153, 228, 73, 163, 238, 29, 165, 245, 204, 7, 177, 69, 88, 250, 161, 103, 14, 14, 73, 63, 17, 16, 73, 79, 201 },
                            PasswordSalt = new byte[] { 92, 47, 98, 88, 179, 197, 145, 247, 4, 24, 160, 55, 35, 155, 238, 108, 210, 3, 99, 196, 70, 175, 60, 141, 76, 48, 104, 110, 35, 122, 177, 98, 170, 160, 235, 148, 228, 16, 210, 57, 221, 69, 195, 9, 163, 187, 75, 192, 154, 26, 35, 142, 129, 146, 184, 191, 62, 35, 64, 251, 109, 51, 157, 14 },
                            Status = false
                        });
                });

            modelBuilder.Entity("Core.Domain.Entities.UserOperationClaim", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "OperationClaimId");

                    b.HasIndex("OperationClaimId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgrammingLanguages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Go"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Python"
                        },
                        new
                        {
                            Id = 5,
                            Name = "JavaScript"
                        });
                });

            modelBuilder.Entity("Domain.Entities.SocialMediaAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("UserId");

                    b.ToTable("SocialMediaAccounts");
                });

            modelBuilder.Entity("Domain.Entities.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgrammingLanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgrammingLanguageId");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Asp.Net",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blazor",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = ".Net MAUI",
                            ProgrammingLanguageId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Spring",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "JSP",
                            ProgrammingLanguageId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Gin",
                            ProgrammingLanguageId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Django",
                            ProgrammingLanguageId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Flask",
                            ProgrammingLanguageId = 4
                        },
                        new
                        {
                            Id = 9,
                            Name = "Angular",
                            ProgrammingLanguageId = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "Vue",
                            ProgrammingLanguageId = 5
                        });
                });

            modelBuilder.Entity("Domain.Entities.Developer", b =>
                {
                    b.HasBaseType("Core.Domain.Entities.User");

                    b.HasDiscriminator().HasValue("Developer");
                });

            modelBuilder.Entity("Core.Domain.Entities.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Domain.Entities.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.SocialMediaAccount", b =>
                {
                    b.HasOne("Domain.Entities.Developer", null)
                        .WithMany("SocialMediaAccounts")
                        .HasForeignKey("DeveloperId");

                    b.HasOne("Core.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Technology", b =>
                {
                    b.HasOne("Domain.Entities.ProgrammingLanguage", "ProgrammingLanguage")
                        .WithMany("Technologies")
                        .HasForeignKey("ProgrammingLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProgrammingLanguage");
                });

            modelBuilder.Entity("Core.Domain.Entities.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Core.Domain.Entities.User", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Domain.Entities.ProgrammingLanguage", b =>
                {
                    b.Navigation("Technologies");
                });

            modelBuilder.Entity("Domain.Entities.Developer", b =>
                {
                    b.Navigation("SocialMediaAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
