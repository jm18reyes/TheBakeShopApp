using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theBakeShopApi.Migrations
{
    public partial class InitialDataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("267dd36e-c5af-4c8d-b5ad-3ae28dad37d9"), "assets/sansrival-cake.jpg", "Cake made of layers of buttercream, meringue and chopped cashews.", "Sans Rival Cake", 790m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("a6e4e208-f9bf-4088-b3ef-da009adc61f3"), "assets/black-forest-cake.jpg", "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.", "Black Forest Cake", 805m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("af8853f2-87f2-43d2-878f-cbd6c3b24926"), "assets/red-velvet-cake.jpg", "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.", "Red Velvet Cake", 721m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("baea5f4f-f98c-496c-9ed9-34b7cf1f9190"), "assets/chocolate-cake.jpg", "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.", "Chocolate Cake", 802m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("c26ee15d-0075-449d-8f2e-0626d5f2ee29"), "assets/lemon-cake.jpg", "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).", "Lemon Cake", 600m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("d29d214a-1f8f-4423-8193-a8f963f046a1"), "assets/japanese-cotton-cake.jpg", "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.", "Japanese Cotton Cake", 721m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("d59959f6-2d8b-4e70-8b00-c05a4f87bf6f"), "assets/coffee-cake.jpg", "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake", "Coffee Cake", 721m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("dcb5f2bc-f01e-4304-9931-12aba8e24059"), "assets/cheese-cake.jpg", "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.", "Cheesecake", 781m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("e30c22b2-b15d-4bc3-bc88-10f5c06f4873"), "assets/banana-cake.jpeg", "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.", "Banana Cake", 700m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("e3d4b3cd-f463-42a0-b952-e57794cfdc96"), "assets/funfetti-cake.jpg", "Cake that has rainbow colored sprinkles baked into the batter.", "Funfetti Cake", 714m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("267dd36e-c5af-4c8d-b5ad-3ae28dad37d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6e4e208-f9bf-4088-b3ef-da009adc61f3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af8853f2-87f2-43d2-878f-cbd6c3b24926"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("baea5f4f-f98c-496c-9ed9-34b7cf1f9190"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c26ee15d-0075-449d-8f2e-0626d5f2ee29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d29d214a-1f8f-4423-8193-a8f963f046a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d59959f6-2d8b-4e70-8b00-c05a4f87bf6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dcb5f2bc-f01e-4304-9931-12aba8e24059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e30c22b2-b15d-4bc3-bc88-10f5c06f4873"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3d4b3cd-f463-42a0-b952-e57794cfdc96"));
        }
    }
}
