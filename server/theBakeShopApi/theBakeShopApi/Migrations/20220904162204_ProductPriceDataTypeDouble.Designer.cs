﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using theBakeShopApi.DBContext;

#nullable disable

namespace theBakeShopApi.Migrations
{
    [DbContext(typeof(ProductInfoContext))]
    [Migration("20220904162204_ProductPriceDataTypeDouble")]
    partial class ProductPriceDataTypeDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("ProductPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("923d2c78-853a-4962-a3d8-828dc6e7e97d"),
                            ImageUrl = "assets/coffee-cake.jpg",
                            ProductDescription = "A coffee-flavored cake is typically baked in a circular shape with two layers separated by coffee butter icing, which may also cover the top of the cake",
                            ProductName = "Coffee Cake",
                            ProductPrice = 721.0
                        },
                        new
                        {
                            Id = new Guid("481905d0-bda8-42ad-ab39-d9eb095107ba"),
                            ImageUrl = "assets/banana-cake.jpeg",
                            ProductDescription = "A traditional banana cake is made like a butter cake with the addition of mashed banana for flavour.",
                            ProductName = "Banana Cake",
                            ProductPrice = 700.0
                        },
                        new
                        {
                            Id = new Guid("b1d77370-0409-4bd1-8f5e-97be5a4468e1"),
                            ImageUrl = "assets/funfetti-cake.jpg",
                            ProductDescription = "Cake that has rainbow colored sprinkles baked into the batter.",
                            ProductName = "Funfetti Cake",
                            ProductPrice = 714.0
                        },
                        new
                        {
                            Id = new Guid("1f6e8b91-61a3-4ef9-b030-2e1e553c312c"),
                            ImageUrl = "assets/lemon-cake.jpg",
                            ProductDescription = "The 'lemony' flavour in a lemon cake is from the volatile oils which are present in the fruit's zest,(mainly nerol, limonene and citral).",
                            ProductName = "Lemon Cake",
                            ProductPrice = 600.0
                        },
                        new
                        {
                            Id = new Guid("fdc7b0d9-3201-43ea-8112-56198a02cc01"),
                            ImageUrl = "assets/black-forest-cake.jpg",
                            ProductDescription = "Black Forest gateau consists of several layers of chocolate sponge cake sandwiched with whipped cream and cherries.",
                            ProductName = "Black Forest Cake",
                            ProductPrice = 805.0
                        },
                        new
                        {
                            Id = new Guid("3476532e-4e1b-4f62-b498-b3eeefeeaa3d"),
                            ImageUrl = "assets/cheese-cake.jpg",
                            ProductDescription = "The main, and thickest, layer consists of a mixture of a soft, fresh cheese, eggs, and sugar.",
                            ProductName = "Cheesecake",
                            ProductPrice = 781.0
                        },
                        new
                        {
                            Id = new Guid("a62eec3c-bfd3-4099-85c2-670928332aa6"),
                            ImageUrl = "assets/red-velvet-cake.jpg",
                            ProductDescription = "Red velvet cake is traditionally a red, red-brown, crimson, or scarlet-colored chocolate layer cake, layered with ermine icing.",
                            ProductName = "Red Velvet Cake",
                            ProductPrice = 721.0
                        },
                        new
                        {
                            Id = new Guid("8785cb2d-58d9-41f2-8ad4-626703ceb880"),
                            ImageUrl = "assets/chocolate-cake.jpg",
                            ProductDescription = "Chocolate cake or chocolate gâteau is a cake flavored with melted chocolate, cocoa powder, or both.",
                            ProductName = "Chocolate Cake",
                            ProductPrice = 802.0
                        },
                        new
                        {
                            Id = new Guid("6537ab1b-3b09-4465-979c-bd3f1113e50a"),
                            ImageUrl = "assets/sansrival-cake.jpg",
                            ProductDescription = "Cake made of layers of buttercream, meringue and chopped cashews.",
                            ProductName = "Sans Rival Cake",
                            ProductPrice = 790.0
                        },
                        new
                        {
                            Id = new Guid("75ec86ae-985e-496c-86d0-dc57956ad9a7"),
                            ImageUrl = "assets/japanese-cotton-cake.jpg",
                            ProductDescription = "Is a variety of cheesecake that is usually lighter in texture and less sweet than North American-style cheesecakes.",
                            ProductName = "Japanese Cotton Cake",
                            ProductPrice = 721.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
