﻿// <auto-generated />
using System;
using Cafedebug.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cafedebug.Data.Migrations
{
    [DbContext(typeof(CafedebugContext))]
    partial class CafedebugContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cafedebug.Business.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ImageId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Banner");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ative")
                        .HasColumnType("bit");

                    b.Property<Guid>("Code");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.EpisodeTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EpisodeId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("EpisodeId");

                    b.HasIndex("TagId");

                    b.ToTable("EpisodeTag");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Code");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Code");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("ImageId");

                    b.Property<string>("NewsLink")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("Code");

                    b.Property<int>("ImageId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("UrlLinkedin")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UrlTwitter")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Sponsor");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("Code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.HasKey("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Banner", b =>
                {
                    b.HasOne("Cafedebug.Business.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.EpisodeTag", b =>
                {
                    b.HasOne("Cafedebug.Business.Models.Episode", "Episode")
                        .WithMany("EpisodiesTags")
                        .HasForeignKey("EpisodeId");

                    b.HasOne("Cafedebug.Business.Models.Tag", "Tag")
                        .WithMany("EpisodesTags")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.News", b =>
                {
                    b.HasOne("Cafedebug.Business.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });

            modelBuilder.Entity("Cafedebug.Business.Models.Sponsor", b =>
                {
                    b.HasOne("Cafedebug.Business.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
