﻿// <auto-generated />
using System;
using BTM.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BTM.Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190514203839_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BTM.Models.ActingRole", b =>
                {
                    b.Property<int>("ActingRoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CharacterName");

                    b.Property<int>("PeopleID");

                    b.HasKey("ActingRoleID");

                    b.HasIndex("PeopleID");

                    b.ToTable("ActingRoles");
                });

            modelBuilder.Entity("BTM.Models.Award", b =>
                {
                    b.Property<int>("AwardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwardShowID");

                    b.Property<int>("AwardTypeID");

                    b.Property<int>("MediaID");

                    b.Property<string>("Name");

                    b.Property<int>("Year");

                    b.HasKey("AwardID");

                    b.HasIndex("AwardShowID");

                    b.HasIndex("AwardTypeID");

                    b.HasIndex("MediaID");

                    b.ToTable("Awards");
                });

            modelBuilder.Entity("BTM.Models.AwardShow", b =>
                {
                    b.Property<int>("AwardShowID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("AwardShowID");

                    b.ToTable("AwardShows");
                });

            modelBuilder.Entity("BTM.Models.AwardType", b =>
                {
                    b.Property<int>("AwardTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("AwardTypeID");

                    b.ToTable("AwardTypes");
                });

            modelBuilder.Entity("BTM.Models.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<int>("Priority");

                    b.Property<bool>("Resolved");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Bugs");
                });

            modelBuilder.Entity("BTM.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BTM.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Addressed");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Name");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("BTM.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("BTM.Models.Image", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<int>("MediaID");

                    b.HasKey("ImageID");

                    b.HasIndex("MediaID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BTM.Models.Language", b =>
                {
                    b.Property<int>("LanguageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageName");

                    b.HasKey("LanguageID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("BTM.Models.List", b =>
                {
                    b.Property<int>("ListID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("UserID");

                    b.HasKey("ListID");

                    b.HasIndex("UserID");

                    b.ToTable("Lists");
                });

            modelBuilder.Entity("BTM.Models.MPAARating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("RatingID");

                    b.ToTable("MPAARating");
                });

            modelBuilder.Entity("BTM.Models.Media", b =>
                {
                    b.Property<int>("MediaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget");

                    b.Property<string>("Director");

                    b.Property<int>("Duration");

                    b.Property<int>("RatingID");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<int>("StudioID");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.Property<double>("WorldwideGross");

                    b.HasKey("MediaID");

                    b.HasIndex("RatingID");

                    b.HasIndex("StudioID");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("BTM.Models.MediaActingRole", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("ActingRoleID");

                    b.HasKey("MediaID", "ActingRoleID");

                    b.HasIndex("ActingRoleID");

                    b.ToTable("MediaActingRoles");
                });

            modelBuilder.Entity("BTM.Models.MediaCountry", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("CountryID");

                    b.HasKey("MediaID", "CountryID");

                    b.HasIndex("CountryID");

                    b.ToTable("MediaCountries");
                });

            modelBuilder.Entity("BTM.Models.MediaGenre", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("GenreID");

                    b.HasKey("MediaID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("MediaGenre");
                });

            modelBuilder.Entity("BTM.Models.MediaLanguage", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("LanguageID");

                    b.HasKey("MediaID", "LanguageID");

                    b.HasIndex("LanguageID");

                    b.ToTable("MediaLanguage");
                });

            modelBuilder.Entity("BTM.Models.MediaList", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("ListID");

                    b.HasKey("MediaID", "ListID");

                    b.HasIndex("ListID");

                    b.ToTable("MediaLists");
                });

            modelBuilder.Entity("BTM.Models.MediaPeopleSetRole", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("PeopleID");

                    b.Property<int>("SetRoleID");

                    b.HasKey("MediaID", "PeopleID", "SetRoleID");

                    b.HasIndex("PeopleID");

                    b.HasIndex("SetRoleID");

                    b.ToTable("MediaPeopleSetRole");
                });

            modelBuilder.Entity("BTM.Models.MediaPlotKeywords", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("KeywordID");

                    b.HasKey("MediaID", "KeywordID");

                    b.HasIndex("KeywordID");

                    b.ToTable("MediaPlotKeywords");
                });

            modelBuilder.Entity("BTM.Models.MediaUser", b =>
                {
                    b.Property<int>("MediaID");

                    b.Property<int>("UserID");

                    b.Property<int>("Grade");

                    b.HasKey("MediaID", "UserID");

                    b.HasIndex("UserID");

                    b.ToTable("MediaUsers");
                });

            modelBuilder.Entity("BTM.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Logo");

                    b.Property<string>("Title");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("BTM.Models.People", b =>
                {
                    b.Property<int>("PeopleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.HasKey("PeopleID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BTM.Models.PlotKeywords", b =>
                {
                    b.Property<int>("KeywordID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KeywordName");

                    b.HasKey("KeywordID");

                    b.ToTable("PlotKeywords");
                });

            modelBuilder.Entity("BTM.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BTM.Models.SetRole", b =>
                {
                    b.Property<int>("SetRoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("SetRoleID");

                    b.ToTable("SetRoles");
                });

            modelBuilder.Entity("BTM.Models.Soundtrack", b =>
                {
                    b.Property<int>("SoundtrackID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<string>("Location");

                    b.Property<int>("MediaID");

                    b.Property<string>("Name");

                    b.HasKey("SoundtrackID");

                    b.HasIndex("MediaID");

                    b.ToTable("Soundtracks");
                });

            modelBuilder.Entity("BTM.Models.Studio", b =>
                {
                    b.Property<int>("StudioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("StudioID");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("BTM.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateAdded");

                    b.Property<bool>("Resolved");

                    b.Property<string>("Title");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BTM.Models.Trailer", b =>
                {
                    b.Property<int>("TrailerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<int>("MediaID");

                    b.HasKey("TrailerID");

                    b.HasIndex("MediaID");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("BTM.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<string>("FBLink");

                    b.Property<string>("FirstName");

                    b.Property<string>("InstagramLink");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName");

                    b.Property<string>("LinkedInLink");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<string>("TwitterLink");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BTM.Models.UsersRoles", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID");

                    b.Property<int>("UserID");

                    b.HasKey("UserRoleID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BTM.Models.ActingRole", b =>
                {
                    b.HasOne("BTM.Models.People", "People")
                        .WithMany()
                        .HasForeignKey("PeopleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Award", b =>
                {
                    b.HasOne("BTM.Models.AwardShow", "AwardShow")
                        .WithMany("Awards")
                        .HasForeignKey("AwardShowID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.AwardType", "AwardType")
                        .WithMany("Awards")
                        .HasForeignKey("AwardTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Bug", b =>
                {
                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Feedback", b =>
                {
                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Image", b =>
                {
                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.List", b =>
                {
                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Media", b =>
                {
                    b.HasOne("BTM.Models.MPAARating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Studio", "Studio")
                        .WithMany("Media")
                        .HasForeignKey("StudioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaActingRole", b =>
                {
                    b.HasOne("BTM.Models.ActingRole", "ActingRole")
                        .WithMany()
                        .HasForeignKey("ActingRoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaCountry", b =>
                {
                    b.HasOne("BTM.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaGenre", b =>
                {
                    b.HasOne("BTM.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaLanguage", b =>
                {
                    b.HasOne("BTM.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaList", b =>
                {
                    b.HasOne("BTM.Models.List", "List")
                        .WithMany()
                        .HasForeignKey("ListID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaPeopleSetRole", b =>
                {
                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.People", "People")
                        .WithMany()
                        .HasForeignKey("PeopleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.SetRole", "SetRole")
                        .WithMany()
                        .HasForeignKey("SetRoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaPlotKeywords", b =>
                {
                    b.HasOne("BTM.Models.PlotKeywords", "Keyword")
                        .WithMany()
                        .HasForeignKey("KeywordID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.MediaUser", b =>
                {
                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.News", b =>
                {
                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Soundtrack", b =>
                {
                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Ticket", b =>
                {
                    b.HasOne("BTM.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.Trailer", b =>
                {
                    b.HasOne("BTM.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BTM.Models.UsersRoles", b =>
                {
                    b.HasOne("BTM.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BTM.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
