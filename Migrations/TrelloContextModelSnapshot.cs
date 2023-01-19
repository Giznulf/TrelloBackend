﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrelloBackend.Models;

#nullable disable

namespace TrelloBackend.Migrations
{
    [DbContext(typeof(TrelloContext))]
    partial class TrelloContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TrelloBackend.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ColumnId")
                        .HasColumnType("int");

                    b.Property<string>("NameCard")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ColumnId");

                    b.ToTable("Cards", (string)null);
                });

            modelBuilder.Entity("TrelloBackend.Models.Column", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameColumn")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Columns", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameColumn = "test"
                        });
                });

            modelBuilder.Entity("TrelloBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin",
                            Password = "qwerty"
                        },
                        new
                        {
                            Id = 2,
                            Name = "tim",
                            Password = "tim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "user",
                            Password = "password"
                        });
                });

            modelBuilder.Entity("TrelloBackend.Models.Card", b =>
                {
                    b.HasOne("TrelloBackend.Models.Column", "Column")
                        .WithMany("Cards")
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Column");
                });

            modelBuilder.Entity("TrelloBackend.Models.Column", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
