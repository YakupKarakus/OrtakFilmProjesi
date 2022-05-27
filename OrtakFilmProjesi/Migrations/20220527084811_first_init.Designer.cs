﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrtakFilmProjesi.Models.Database;

namespace OrtakFilmProjesi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220527084811_first_init")]
    partial class first_init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("FilmsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "FilmsId");

                    b.HasIndex("FilmsId");

                    b.ToTable("CategoryFilm");
                });

            modelBuilder.Entity("FilmSession", b =>
                {
                    b.Property<int>("FilmsId")
                        .HasColumnType("int");

                    b.Property<int>("SessionsId")
                        .HasColumnType("int");

                    b.HasKey("FilmsId", "SessionsId");

                    b.HasIndex("SessionsId");

                    b.ToTable("FilmSession");
                });

            modelBuilder.Entity("OrtakFilmProjesi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OrtakFilmProjesi.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fiziksel ve ruhsal bir şifa yolculuğundayken, parlak bir beyin cerrahı mistik sanatların dünyasına çekilir.",
                            Name = "Dr.Strange",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Asil bir aile, galaksinin en değerli varlığı üzerinde kontrol için bir savaşa girerken, varisi karanlık bir geleceğin vizyonları tarafından rahatsız edilir.",
                            Name = "Dune",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bir kaşif ekibi, insanlığın hayatta kalmasını sağlamak için uzayda bir solucan deliğinden geçer.",
                            Name = "Interstellar",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Thor, tanrıları yok etmeyi amaçlayan Tanrı Kasabı Gorr ile savaşmak için Valkyrie, Korg ve eski kız arkadaşı Jane Foster'dan yardım ister.",
                            Name = "Thor",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Donanmanın en iyi havacılarından biri olarak otuz yıldan fazla hizmet verdikten sonra, Pete Mitchell ait olduğu yerdedir, cesur bir test pilotu olarak sınırları zorlar ve onu yere indirecek rütbedeki ilerlemeden kaçınır.",
                            Name = "TopGun",
                            Price = 50.0
                        });
                });

            modelBuilder.Entity("OrtakFilmProjesi.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("SessionTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("OrtakFilmProjesi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mail = "admin@hotmail.com",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 2,
                            Mail = "user1@hotmail.com",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("CategoryFilm", b =>
                {
                    b.HasOne("OrtakFilmProjesi.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrtakFilmProjesi.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FilmSession", b =>
                {
                    b.HasOne("OrtakFilmProjesi.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrtakFilmProjesi.Models.Session", null)
                        .WithMany()
                        .HasForeignKey("SessionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
