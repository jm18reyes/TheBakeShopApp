using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theBakeShopApi.Migrations
{
    public partial class ProductPriceDataTypeInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1f6e8b91-61a3-4ef9-b030-2e1e553c312c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3476532e-4e1b-4f62-b498-b3eeefeeaa3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("481905d0-bda8-42ad-ab39-d9eb095107ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6537ab1b-3b09-4465-979c-bd3f1113e50a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75ec86ae-985e-496c-86d0-dc57956ad9a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8785cb2d-58d9-41f2-8ad4-626703ceb880"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("923d2c78-853a-4962-a3d8-828dc6e7e97d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a62eec3c-bfd3-4099-85c2-670928332aa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1d77370-0409-4bd1-8f5e-97be5a4468e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fdc7b0d9-3201-43ea-8112-56198a02cc01"));

            migrationBuilder.AlterColumn<int>(
                name: "ProductPrice",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("00314322-6df2-486e-8006-f0005bce3ddd"), "assets/cheese-cake.jpg", "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.", "Cheesecake", 781 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("144301fc-83ab-4337-aadc-4a398fbcf6e3"), "assets/red-velvet-cake.jpg", "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.", "Red Velvet Cake", 721 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("1995c796-5ba0-4ae0-b7bb-e7e008755b81"), "assets/japanese-cotton-cake.jpg", "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.", "Japanese Cotton Cake", 721 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("4835f50f-76ef-4ed3-b272-3ad48b3723c3"), "assets/black-forest-cake.jpg", "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.", "Black Forest Cake", 805 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("569cfa58-9a4c-4440-91fb-af9d9b3835ea"), "assets/sansrival-cake.jpg", "Cake made of layers of buttercream, meringue and chopped cashews.", "Sans Rival Cake", 790 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("887c959b-5ad0-4a80-89e3-9697e0ea12de"), "assets/chocolate-cake.jpg", "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.", "Chocolate Cake", 802 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("a1d62c8e-1bbd-4919-b56f-7d34247f06de"), "assets/lemon-cake.jpg", "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).", "Lemon Cake", 600 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("b8820605-0377-4694-a51b-4ccf9f827580"), "assets/funfetti-cake.jpg", "Cake that has rainbow colored sprinkles baked into the batter.", "Funfetti Cake", 714 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("d2c43327-f739-49a2-8af8-1a0766626719"), "assets/coffee-cake.jpg", "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake", "Coffee Cake", 721 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("e5cb2d62-a344-4e0c-8b8d-56cd45917faa"), "assets/banana-cake.jpeg", "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.", "Banana Cake", 700 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00314322-6df2-486e-8006-f0005bce3ddd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("144301fc-83ab-4337-aadc-4a398fbcf6e3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1995c796-5ba0-4ae0-b7bb-e7e008755b81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4835f50f-76ef-4ed3-b272-3ad48b3723c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("569cfa58-9a4c-4440-91fb-af9d9b3835ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("887c959b-5ad0-4a80-89e3-9697e0ea12de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1d62c8e-1bbd-4919-b56f-7d34247f06de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8820605-0377-4694-a51b-4ccf9f827580"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2c43327-f739-49a2-8af8-1a0766626719"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5cb2d62-a344-4e0c-8b8d-56cd45917faa"));

            migrationBuilder.AlterColumn<double>(
                name: "ProductPrice",
                table: "Products",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("1f6e8b91-61a3-4ef9-b030-2e1e553c312c"), "assets/lemon-cake.jpg", "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).", "Lemon Cake", 600.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("3476532e-4e1b-4f62-b498-b3eeefeeaa3d"), "assets/cheese-cake.jpg", "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.", "Cheesecake", 781.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("481905d0-bda8-42ad-ab39-d9eb095107ba"), "assets/banana-cake.jpeg", "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.", "Banana Cake", 700.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("6537ab1b-3b09-4465-979c-bd3f1113e50a"), "assets/sansrival-cake.jpg", "Cake made of layers of buttercream, meringue and chopped cashews.", "Sans Rival Cake", 790.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("75ec86ae-985e-496c-86d0-dc57956ad9a7"), "assets/japanese-cotton-cake.jpg", "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.", "Japanese Cotton Cake", 721.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("8785cb2d-58d9-41f2-8ad4-626703ceb880"), "assets/chocolate-cake.jpg", "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.", "Chocolate Cake", 802.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("923d2c78-853a-4962-a3d8-828dc6e7e97d"), "assets/coffee-cake.jpg", "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake", "Coffee Cake", 721.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("a62eec3c-bfd3-4099-85c2-670928332aa6"), "assets/red-velvet-cake.jpg", "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.", "Red Velvet Cake", 721.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("b1d77370-0409-4bd1-8f5e-97be5a4468e1"), "assets/funfetti-cake.jpg", "Cake that has rainbow colored sprinkles baked into the batter.", "Funfetti Cake", 714.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ImageUrl", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { new Guid("fdc7b0d9-3201-43ea-8112-56198a02cc01"), "assets/black-forest-cake.jpg", "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.", "Black Forest Cake", 805.0 });
        }
    }
}
