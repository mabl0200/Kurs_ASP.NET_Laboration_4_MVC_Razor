using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Migrations
{
    public partial class FirstCreationWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Author = table.Column<string>(maxLength: 50, nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    ImageThumbnail = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    BorrowedBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    IsReturned = table.Column<bool>(nullable: false),
                    StartOfLoanPeriod = table.Column<DateTime>(nullable: true),
                    EndOfLoanPeriod = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.BorrowedBookId);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "ISBN", "ImageThumbnail", "IsAvailable", "Name" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", "9789129723946", "\\Labb4Images\\harry-potter-och-de-vises-sten.jpg", true, "Harry Potter och de vises sten" },
                    { 9, "Mia Kankimäki", "9789146239307", "\\Labb4Images\\kvinnor-jag-tanker-pa-om-natten.jpg", true, "Kvinnor jag tänker på om natten" },
                    { 8, "Hans Rosling", "9789127166356", "\\Labb4Images\\hur-jag-larde-mig-forsta-varlden.jpg", true, "Hur jag lärde mig förstå världen" },
                    { 7, "RB Whitaker", "9780985580148", "\\Labb4Images\\the-c-players-guide-4th-edition.jpg", true, "The C# Player's Guide (4th Edition)" },
                    { 6, "Kate Chopin", "9781847498250", "\\Labb4Images\\the-awakening.jpg", true, "The Awakening" },
                    { 10, "Delia Owens", "9789137157726", "\\Labb4Images\\dar-kraftorna-sjunger.jpg", true, "Där kräftorna sjunger" },
                    { 4, "J.R.R. Tolkien", "9789113084893", "\\Labb4Images\\hobbiten-eller-bort-och-hem-igen.jpg", true, "Hobbiten : eller Bort och hem igen" },
                    { 3, "Arundhati Roy", "9780006550686", "\\Labb4Images\\god-of-small-things.jpg", true, "God of Small Things" },
                    { 2, "Sara Lövestam", "9789164207937", "\\Labb4Images\\bara-och-brista-andra-monikabok.jpg", true, "Bära och brista : andra Monikabok" },
                    { 5, "Viveca Sten", "9788416087631", "\\Labb4Images\\i-de-lugnaste-vatten.jpg", true, "En aguas tranquilas" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 9, "robert@hello.se", "Robert", "Skog" },
                    { 1, "margit@hello.se", "Margit", "Danielsson" },
                    { 2, "teresa@hello.se", "Teresa", "Gustavsson" },
                    { 3, "emmy@hello.se", "Emmy", "Ahlgren" },
                    { 4, "jennie@hello.se", "Jennie", "Svensson" },
                    { 5, "christine@hello.se", "Christine", "Jönsson" },
                    { 6, "mats@hello.se", "Mats", "Nyquist" },
                    { 7, "linus@hello.se", "Linus", "Olsson" },
                    { 8, "carl@hello.se", "Carl", "Hamilton" },
                    { 10, "andreas@hello.se", "Andreas", "Östberg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_CustomerId",
                table: "BorrowedBooks",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
