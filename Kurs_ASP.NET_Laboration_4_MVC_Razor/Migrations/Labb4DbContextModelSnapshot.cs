﻿// <auto-generated />
using System;
using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Migrations
{
    [DbContext(typeof(Labb4DbContext))]
    partial class Labb4DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "J.K. Rowling",
                            ISBN = "9789129723946",
                            ImageThumbnail = "\\Labb4Images\\harry-potter-och-de-vises-sten.jpg",
                            IsAvailable = true,
                            Name = "Harry Potter och de vises sten"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Sara Lövestam",
                            ISBN = "9789164207937",
                            ImageThumbnail = "\\Labb4Images\\bara-och-brista-andra-monikabok.jpg",
                            IsAvailable = true,
                            Name = "Bära och brista : andra Monikabok"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Arundhati Roy",
                            ISBN = "9780006550686",
                            ImageThumbnail = "\\Labb4Images\\god-of-small-things.jpg",
                            IsAvailable = true,
                            Name = "God of Small Things"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "J.R.R. Tolkien",
                            ISBN = "9789113084893",
                            ImageThumbnail = "\\Labb4Images\\hobbiten-eller-bort-och-hem-igen.jpg",
                            IsAvailable = true,
                            Name = "Hobbiten : eller Bort och hem igen"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Viveca Sten",
                            ISBN = "9788416087631",
                            ImageThumbnail = "\\Labb4Images\\i-de-lugnaste-vatten.jpg",
                            IsAvailable = true,
                            Name = "En aguas tranquilas"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Kate Chopin",
                            ISBN = "9781847498250",
                            ImageThumbnail = "\\Labb4Images\\the-awakening.jpg",
                            IsAvailable = true,
                            Name = "The Awakening"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "RB Whitaker",
                            ISBN = "9780985580148",
                            ImageThumbnail = "\\Labb4Images\\the-c-players-guide-4th-edition.jpg",
                            IsAvailable = true,
                            Name = "The C# Player's Guide (4th Edition)"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Hans Rosling",
                            ISBN = "9789127166356",
                            ImageThumbnail = "\\Labb4Images\\hur-jag-larde-mig-forsta-varlden.jpg",
                            IsAvailable = true,
                            Name = "Hur jag lärde mig förstå världen"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Mia Kankimäki",
                            ISBN = "9789146239307",
                            ImageThumbnail = "\\Labb4Images\\kvinnor-jag-tanker-pa-om-natten.jpg",
                            IsAvailable = true,
                            Name = "Kvinnor jag tänker på om natten"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Delia Owens",
                            ISBN = "9789137157726",
                            ImageThumbnail = "\\Labb4Images\\dar-kraftorna-sjunger.jpg",
                            IsAvailable = true,
                            Name = "Där kräftorna sjunger"
                        });
                });

            modelBuilder.Entity("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.BorrowedBook", b =>
                {
                    b.Property<int>("BorrowedBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndOfLoanPeriod")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartOfLoanPeriod")
                        .HasColumnType("datetime2");

                    b.HasKey("BorrowedBookId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "margit@hello.se",
                            FirstName = "Margit",
                            LastName = "Danielsson"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "teresa@hello.se",
                            FirstName = "Teresa",
                            LastName = "Gustavsson"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "emmy@hello.se",
                            FirstName = "Emmy",
                            LastName = "Ahlgren"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "jennie@hello.se",
                            FirstName = "Jennie",
                            LastName = "Svensson"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "christine@hello.se",
                            FirstName = "Christine",
                            LastName = "Jönsson"
                        },
                        new
                        {
                            CustomerId = 6,
                            Email = "mats@hello.se",
                            FirstName = "Mats",
                            LastName = "Nyquist"
                        },
                        new
                        {
                            CustomerId = 7,
                            Email = "linus@hello.se",
                            FirstName = "Linus",
                            LastName = "Olsson"
                        },
                        new
                        {
                            CustomerId = 8,
                            Email = "carl@hello.se",
                            FirstName = "Carl",
                            LastName = "Hamilton"
                        },
                        new
                        {
                            CustomerId = 9,
                            Email = "robert@hello.se",
                            FirstName = "Robert",
                            LastName = "Skog"
                        },
                        new
                        {
                            CustomerId = 10,
                            Email = "andreas@hello.se",
                            FirstName = "Andreas",
                            LastName = "Östberg"
                        });
                });

            modelBuilder.Entity("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.BorrowedBook", b =>
                {
                    b.HasOne("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.Book", "Book")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kurs_ASP.NET_Laboration_4_MVC_Razor.Models.Customer", "Customer")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}