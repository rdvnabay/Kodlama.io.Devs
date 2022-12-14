// <auto-generated />
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
    [Migration("20220910171921_Edit-SocialMediaAccountTable")]
    partial class EditSocialMediaAccountTable
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
                            Email = "Muaviye36@hotmail.com",
                            FirstName = "Muaviye",
                            LastName = "Aykaç",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "Oksan.Tekand74@yahoo.com",
                            FirstName = "Okşan",
                            LastName = "Tekand",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = false
                        },
                        new
                        {
                            Id = 3,
                            Email = "Bora_Hakyemez80@gmail.com",
                            FirstName = "Bora",
                            LastName = "Hakyemez",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Email = "Tayfun.Berberoglu16@yahoo.com",
                            FirstName = "Tayfun",
                            LastName = "Berberoğlu",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            Email = "Veysel43@gmail.com",
                            FirstName = "Veysel",
                            LastName = "Günday",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = false
                        },
                        new
                        {
                            Id = 6,
                            Email = "Misbah_Erturk@gmail.com",
                            FirstName = "Misbah",
                            LastName = "Ertürk",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = false
                        },
                        new
                        {
                            Id = 7,
                            Email = "Yeliz_Limoncuoglu55@gmail.com",
                            FirstName = "Yeliz",
                            LastName = "Limoncuoğlu",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            Email = "Muhammed_Arican87@yahoo.com",
                            FirstName = "Muhammed",
                            LastName = "Arıcan",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = false
                        },
                        new
                        {
                            Id = 9,
                            Email = "Kamil_Ozbir@hotmail.com",
                            FirstName = "Kâmil",
                            LastName = "Özbir",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
                            Status = false
                        },
                        new
                        {
                            Id = 10,
                            Email = "Defne.Ozberk27@hotmail.com",
                            FirstName = "Defne",
                            LastName = "Özberk",
                            PasswordHash = new byte[] { 225, 59, 5, 52, 164, 229, 161, 36, 107, 158, 118, 159, 197, 238, 106, 246, 135, 92, 40, 126, 7, 247, 13, 100, 0, 196, 127, 120, 114, 230, 187, 85, 99, 45, 88, 49, 79, 52, 228, 219, 41, 249, 10, 254, 13, 21, 186, 142, 85, 26, 91, 171, 126, 230, 71, 191, 171, 48, 5, 29, 65, 241, 253, 47, 89, 129, 21, 136, 202, 68, 71, 189, 106, 252, 35, 126, 139, 123, 245, 246, 164, 207, 120, 215, 19, 60, 129, 173, 45, 96, 11, 191, 225, 239, 3, 174, 151, 194, 74, 228, 75, 128, 194, 31, 145, 175, 163, 2, 54, 75, 195, 183, 67, 27, 34, 201, 162, 33, 177, 185, 4, 136, 17, 115, 135, 163, 168, 141 },
                            PasswordSalt = new byte[] { 18, 176, 223, 80, 119, 5, 74, 215, 7, 145, 46, 139, 36, 21, 215, 58, 3, 49, 164, 198, 14, 246, 231, 100, 84, 136, 230, 62, 213, 69, 214, 11, 100, 217, 140, 101, 235, 197, 143, 93, 13, 55, 32, 222, 208, 46, 209, 105, 199, 245, 85, 35, 120, 166, 191, 109, 162, 156, 55, 222, 116, 46, 190, 219 },
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

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

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
                    b.HasOne("Domain.Entities.Developer", "Developer")
                        .WithMany("SocialMediaAccounts")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");
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
