using Microsoft.EntityFrameworkCore;
using theBakeShopApi.Entities;

namespace theBakeShopApi.DBContext
{
    public class ProductInfoContext: DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;

        public ProductInfoContext(DbContextOptions<ProductInfoContext> options)
            :base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Coffee Cake",
                    ProductDescription = "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake",
                    ProductPrice = 721,
                    ImageUrl = "assets/coffee-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Banana Cake",
                    ProductDescription = "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.",
                    ProductPrice = 700,
                    ImageUrl = "assets/banana-cake.jpeg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Funfetti Cake",
                    ProductDescription = "Cake that has rainbow colored sprinkles baked into the batter.",
                    ProductPrice = 714,
                    ImageUrl = "assets/funfetti-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Lemon Cake",
                    ProductDescription = "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).",
                    ProductPrice = 600,
                    ImageUrl = "assets/lemon-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Black Forest Cake",
                    ProductDescription = "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.",
                    ProductPrice = 805,
                    ImageUrl = "assets/black-forest-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Cheesecake",
                    ProductDescription = "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.",
                    ProductPrice = 781,
                    ImageUrl = "assets/cheese-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Red Velvet Cake",
                    ProductDescription = "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.",
                    ProductPrice = 721,
                    ImageUrl = "assets/red-velvet-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Chocolate Cake",
                    ProductDescription = "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.",
                    ProductPrice = 802,
                    ImageUrl = "assets/chocolate-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Sans Rival Cake",
                    ProductDescription = "Cake made of layers of buttercream, meringue and chopped cashews.",
                    ProductPrice = 790,
                    ImageUrl = "assets/sansrival-cake.jpg"

                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Japanese Cotton Cake",
                    ProductDescription = "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.",
                    ProductPrice = 721,
                    ImageUrl = "assets/japanese-cotton-cake.jpg"

                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
