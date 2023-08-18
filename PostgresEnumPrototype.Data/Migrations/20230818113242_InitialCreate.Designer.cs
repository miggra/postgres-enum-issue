﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgresEnumPrototype.Data;

#nullable disable

namespace PostgresEnumPrototype.Data.Migrations
{
    [DbContext(typeof(MessageContext))]
    [Migration("20230818113242_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PostgresEnumPrototype.Data.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body")
                        .HasColumnOrder(3);

                    b.Property<Guid>("RecipientId")
                        .HasColumnType("uuid")
                        .HasColumnName("recipient_id")
                        .HasColumnOrder(1);

                    b.Property<DateTimeOffset>("SendDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("send_date_time")
                        .HasColumnOrder(4);

                    b.Property<string>("Subject")
                        .HasColumnType("text")
                        .HasColumnName("subject")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("messages");
                });
#pragma warning restore 612, 618
        }
    }
}