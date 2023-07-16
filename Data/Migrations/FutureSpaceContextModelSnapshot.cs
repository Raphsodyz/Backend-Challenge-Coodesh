﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(FutureSpaceContext))]
    partial class FutureSpaceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FAMILY");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FULL_NAME");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<int?>("LaunchLibraryId")
                        .HasColumnType("int")
                        .HasColumnName("LAUNCH_LIBRARY_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("URL");

                    b.Property<string>("Variant")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("VARIANT");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("CONFIGURATION");
                });

            modelBuilder.Entity("Domain.Entities.Launch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<Guid>("ApiGuId")
                        .HasColumnType("char(36)")
                        .HasColumnName("API_GUID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<string>("FailReason")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("FAIL_REASON");

                    b.Property<string>("Hashtag")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("HASHTAG");

                    b.Property<string>("HoldReason")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("HOLD_REASON");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<int>("IdLaunchServiceProvider")
                        .HasColumnType("int")
                        .HasColumnName("ID_LAUNCH_SERVICE_PROVIDER");

                    b.Property<int>("IdMission")
                        .HasColumnType("int")
                        .HasColumnName("ID_MISSION");

                    b.Property<int>("IdPad")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAD");

                    b.Property<int>("IdRocket")
                        .HasColumnType("int")
                        .HasColumnName("ID_ROCKET");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int")
                        .HasColumnName("ID_STATUS");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("IMAGE");

                    b.Property<string>("Infographic")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("INFOGRAPHIC");

                    b.Property<bool>("Inhold")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("INHOLD");

                    b.Property<int?>("LaunchLibraryId")
                        .HasColumnType("int")
                        .HasColumnName("LAUNCH_LIBRARY_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<DateTime>("Net")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("NET");

                    b.Property<int?>("Probability")
                        .HasColumnType("int")
                        .HasColumnName("PROBABILITY");

                    b.Property<string>("Programs")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PROGRAMS");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("SLUG");

                    b.Property<bool>("TbdDate")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("TBD_DATE");

                    b.Property<bool>("TbdTime")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("TBD_TIME");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("URL");

                    b.Property<bool>("WebcastLive")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("WEB_CAST_LIVE");

                    b.Property<DateTime>("WindowEnd")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("WINDOW_END");

                    b.Property<DateTime>("WindowStart")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("WINDOW_START");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("IdLaunchServiceProvider");

                    b.HasIndex("IdMission");

                    b.HasIndex("IdPad");

                    b.HasIndex("IdRocket");

                    b.HasIndex("IdStatus");

                    b.ToTable("LAUNCH");
                });

            modelBuilder.Entity("Domain.Entities.LaunchDesignator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("LAUNCH_DESIGNATOR");
                });

            modelBuilder.Entity("Domain.Entities.LaunchServiceProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("TYPE");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("URL");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("LAUNCH_SERVICE_PROVIDER");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("COUNTRY_CODE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<string>("MapImage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("MAP_IMAGE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<int>("TotalLandingCount")
                        .HasColumnType("int")
                        .HasColumnName("TOTAL_LANDING_COUNT");

                    b.Property<int>("TotalLaunchCount")
                        .HasColumnType("int")
                        .HasColumnName("TOTAL_LAUNCH_COUNT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("URL");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("LOCATION");
                });

            modelBuilder.Entity("Domain.Entities.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("DESCRIPTION");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<int>("IdLaunchDesignator")
                        .HasColumnType("int")
                        .HasColumnName("ID_LAUNCH_DESIGNATOR");

                    b.Property<int>("IdOrbit")
                        .HasColumnType("int")
                        .HasColumnName("ID_ORBIT");

                    b.Property<int?>("LaunchLibraryId")
                        .HasColumnType("int")
                        .HasColumnName("LAUNCH_LIBRARY_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("TYPE");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("IdLaunchDesignator");

                    b.HasIndex("IdOrbit");

                    b.ToTable("MISSION");
                });

            modelBuilder.Entity("Domain.Entities.Orbit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Abbrev")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ABBREV");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("ORBIT");
                });

            modelBuilder.Entity("Domain.Entities.Pad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int")
                        .HasColumnName("AGENCY_ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<int>("IdLocation")
                        .HasColumnType("int")
                        .HasColumnName("ID_LOCATION");

                    b.Property<string>("InfoUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("INFO_URL");

                    b.Property<double>("Latitude")
                        .HasColumnType("double")
                        .HasColumnName("LATITUDE");

                    b.Property<double>("Longitude")
                        .HasColumnType("double")
                        .HasColumnName("LONGITUDE");

                    b.Property<string>("MapImage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("MAP_IMAGE");

                    b.Property<string>("MapUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("MAP_URL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<int>("TotalLaunchCount")
                        .HasColumnType("int")
                        .HasColumnName("TOTAL_LAUNCH_COUNT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("URL");

                    b.Property<string>("WikiUrl")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("WIKI_URL");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("IdLocation");

                    b.ToTable("PAD");
                });

            modelBuilder.Entity("Domain.Entities.Rocket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int>("IdConfiguration")
                        .HasColumnType("int")
                        .HasColumnName("ID_CONFIGURATION");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.HasIndex("IdConfiguration");

                    b.ToTable("ROCKET");
                });

            modelBuilder.Entity("Domain.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("AtualizationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("ATUALIZATION_DATE");

                    b.Property<int?>("IdFromApi")
                        .HasColumnType("int")
                        .HasColumnName("ID_FROM_API");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("NAME");

                    b.Property<DateTime>("importedT")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("IMPORTED_T");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("STATUS");
                });

            modelBuilder.Entity("Domain.Entities.Launch", b =>
                {
                    b.HasOne("Domain.Entities.LaunchServiceProvider", "LaunchServiceProvider")
                        .WithMany()
                        .HasForeignKey("IdLaunchServiceProvider")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Mission", "Mission")
                        .WithMany()
                        .HasForeignKey("IdMission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Pad", "Pad")
                        .WithMany()
                        .HasForeignKey("IdPad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rocket", "Rocket")
                        .WithMany()
                        .HasForeignKey("IdRocket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Status", "Status")
                        .WithMany()
                        .HasForeignKey("IdStatus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LaunchServiceProvider");

                    b.Navigation("Mission");

                    b.Navigation("Pad");

                    b.Navigation("Rocket");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Domain.Entities.Mission", b =>
                {
                    b.HasOne("Domain.Entities.LaunchDesignator", "LaunchDesignator")
                        .WithMany()
                        .HasForeignKey("IdLaunchDesignator")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Orbit", "Orbit")
                        .WithMany()
                        .HasForeignKey("IdOrbit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LaunchDesignator");

                    b.Navigation("Orbit");
                });

            modelBuilder.Entity("Domain.Entities.Pad", b =>
                {
                    b.HasOne("Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("IdLocation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Domain.Entities.Rocket", b =>
                {
                    b.HasOne("Domain.Entities.Configuration", "Configuration")
                        .WithMany()
                        .HasForeignKey("IdConfiguration")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuration");
                });
#pragma warning restore 612, 618
        }
    }
}
