﻿// <auto-generated />
using System;
using HSR_CHARACTERS.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HSR_CHARACTERS.API.Migrations
{
    [DbContext(typeof(HSR_CHARACTERSDbContext))]
    partial class HSR_CHARACTERSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HSR_CHARACTERS.API.Models.Domain.CharactersInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CharacterImageIRL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CharactersPathId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharactersTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PathId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CharactersPathId");

                    b.HasIndex("CharactersTypeId");

                    b.ToTable("CharactersInformations");
                });

            modelBuilder.Entity("HSR_CHARACTERS.API.Models.Domain.CharactersPath", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathImageIRL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CharactersPaths");
                });

            modelBuilder.Entity("HSR_CHARACTERS.API.Models.Domain.CharactersType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeImageIRL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CharactersTypes");
                });

            modelBuilder.Entity("HSR_CHARACTERS.API.Models.Domain.CharactersInformation", b =>
                {
                    b.HasOne("HSR_CHARACTERS.API.Models.Domain.CharactersPath", "CharactersPath")
                        .WithMany()
                        .HasForeignKey("CharactersPathId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HSR_CHARACTERS.API.Models.Domain.CharactersType", "CharactersType")
                        .WithMany()
                        .HasForeignKey("CharactersTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharactersPath");

                    b.Navigation("CharactersType");
                });
#pragma warning restore 612, 618
        }
    }
}
