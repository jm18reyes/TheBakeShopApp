﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using theBakeShopApi.DBContext;

#nullable disable

namespace theBakeShopApi.Migrations
{
    [DbContext(typeof(ProductInfoContext))]
    partial class ProductInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("theBakeShopApi.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2c43327-f739-49a2-8af8-1a0766626719"),
                            ImageUrl = "assets/coffee-cake.jpg",
                            ProductDescription = "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake",
                            ProductName = "Coffee Cake",
                            ProductPrice = 721
                        },
                        new
                        {
                            Id = new Guid("e5cb2d62-a344-4e0c-8b8d-56cd45917faa"),
                            ImageUrl = "assets/banana-cake.jpeg",
                            ProductDescription = "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.",
                            ProductName = "Banana Cake",
                            ProductPrice = 700
                        },
                        new
                        {
                            Id = new Guid("b8820605-0377-4694-a51b-4ccf9f827580"),
                            ImageUrl = "assets/funfetti-cake.jpg",
                            ProductDescription = "Cake that has rainbow colored sprinkles baked into the batter.",
                            ProductName = "Funfetti Cake",
                            ProductPrice = 714
                        },
                        new
                        {
                            Id = new Guid("a1d62c8e-1bbd-4919-b56f-7d34247f06de"),
                            ImageUrl = "assets/lemon-cake.jpg",
                            ProductDescription = "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).",
                            ProductName = "Lemon Cake",
                            ProductPrice = 600
                        },
                        new
                        {
                            Id = new Guid("4835f50f-76ef-4ed3-b272-3ad48b3723c3"),
                            ImageUrl = "assets/black-forest-cake.jpg",
                            ProductDescription = "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.",
                            ProductName = "Black Forest Cake",
                            ProductPrice = 805
                        },
                        new
                        {
                            Id = new Guid("00314322-6df2-486e-8006-f0005bce3ddd"),
                            ImageUrl = "assets/cheese-cake.jpg",
                            ProductDescription = "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.",
                            ProductName = "Cheesecake",
                            ProductPrice = 781
                        },
                        new
                        {
                            Id = new Guid("144301fc-83ab-4337-aadc-4a398fbcf6e3"),
                            ImageUrl = "assets/red-velvet-cake.jpg",
                            ProductDescription = "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.",
                            ProductName = "Red Velvet Cake",
                            ProductPrice = 721
                        },
                        new
                        {
                            Id = new Guid("887c959b-5ad0-4a80-89e3-9697e0ea12de"),
                            ImageUrl = "assets/chocolate-cake.jpg",
                            ProductDescription = "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.",
                            ProductName = "Chocolate Cake",
                            ProductPrice = 802
                        },
                        new
                        {
                            Id = new Guid("569cfa58-9a4c-4440-91fb-af9d9b3835ea"),
                            ImageUrl = "assets/sansrival-cake.jpg",
                            ProductDescription = "Cake made of layers of buttercream, meringue and chopped cashews.",
                            ProductName = "Sans Rival Cake",
                            ProductPrice = 790
                        },
                        new
                        {
                            Id = new Guid("1995c796-5ba0-4ae0-b7bb-e7e008755b81"),
                            ImageUrl = "assets/japanese-cotton-cake.jpg",
                            ProductDescription = "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.",
                            ProductName = "Japanese Cotton Cake",
                            ProductPrice = 721
                        });
                });
#pragma warning restore 612, 618
        }
    }
}