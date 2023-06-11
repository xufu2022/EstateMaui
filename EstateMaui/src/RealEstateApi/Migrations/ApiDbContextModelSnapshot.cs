﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateApi.Data;

#nullable disable

namespace RealEstateApi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RealEstateApi.Models.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Bookmarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PropertyId = 1,
                            Status = true,
                            User_Id = 1
                        });
                });

            modelBuilder.Entity("RealEstateApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "house.png",
                            Name = "House"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "hotel.png",
                            Name = "Hotel"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "appartment.png",
                            Name = "Appartment"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "penthouse.png",
                            Name = "Penthouse"
                        });
                });

            modelBuilder.Entity("RealEstateApi.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrending")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ciel Tower, Dubai Marina, Dubai",
                            CategoryId = 1,
                            Detail = "Allsopp Real Estate are pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep1.jpg",
                            IsTrending = false,
                            Name = "Jumeirah Metro City",
                            Price = 800000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dorrabay, Dubai Marina, Dubai",
                            CategoryId = 1,
                            Detail = "Sky golobal Real Estate is pleased to offer this stunning house in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep2.jpg",
                            IsTrending = true,
                            Name = "Stuning Marina",
                            Price = 700000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Address = "Dorrabay, Dubai Marina, Dubai",
                            CategoryId = 1,
                            Detail = "Allsopp Real Estate are pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep3.jpg",
                            IsTrending = false,
                            Name = "Distress Deal",
                            Price = 200000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "TFG Marina , Dubai Marina, Dubai",
                            CategoryId = 2,
                            Detail = "Jumeirah Real Estate is pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep4.jpg",
                            IsTrending = false,
                            Name = "Panoramic Views",
                            Price = 900000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Address = "The Palm Tower, Palm Jumeirah, Dubai",
                            CategoryId = 2,
                            Detail = "Allsopp Real Estate are pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep5.jpg",
                            IsTrending = true,
                            Name = "Palm View",
                            Price = 750000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            Address = "Dorrabay, Dubai Marina, Dubai",
                            CategoryId = 3,
                            Detail = "Allsopp Real Estate are pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep6.jpg",
                            IsTrending = false,
                            Name = "Full Marina View",
                            Price = 200000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            Address = "Attessa, Marina Promenade, Dubai Marina, Dubai",
                            CategoryId = 3,
                            Detail = "We are pleased to offer this stunning two bed apartment in Emaar's 5243, Dubai.Amazing full marina views, from all rooms, this two bedroom apartment is offered vacant and spread over 850 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep7.jpg",
                            IsTrending = true,
                            Name = "Avant Tower",
                            Price = 300000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 8,
                            Address = "Tower B1, Vida Hotel, The Hills, Dubai",
                            CategoryId = 3,
                            Detail = "Eithad Real Estate is pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep8.jpg",
                            IsTrending = false,
                            Name = "Distress Deal",
                            Price = 400000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            Address = "Vida Residence 2, Vida Residence, Dubai",
                            CategoryId = 3,
                            Detail = "Kernizia Real Estate is pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep9.jpg",
                            IsTrending = false,
                            Name = "Sea View",
                            Price = 880000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            Address = "Artesia C, Artesia, DAMAC Hills, Dubai",
                            CategoryId = 4,
                            Detail = "Astro Properties are delighted to present this Excellent investment opportunity to own a hotel room in the heart of Dubai Marina! Wyndham Dubai Marina is an upscale 4* hotel with breathtaking views of the Arabian Sea and Dubai Marina. The hotel is very popular through the guests and visitors and keeps high ranking on booking. com and similar booking portals through all time.",
                            ImageUrl = "imagep10.jpg",
                            IsTrending = false,
                            Name = "Jenkins Height",
                            Price = 5500000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            Address = "Damac Maison The Distinction, Downtown Dubai, Dubai",
                            CategoryId = 4,
                            Detail = "Allsopp Real Estate are pleased to offer this stunning one bedroom apartment in Emaar's 5242, Dubai Marina.Amazing full marina views, from all rooms, this one bedroom apartment is offered vacant and spread over 696 sq. ft. Perfect for short term holiday lets or as a first home.",
                            ImageUrl = "imagep11.jpg",
                            IsTrending = false,
                            Name = "Takishi Penhouse",
                            Price = 800000.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 12,
                            Address = "Dorrabay, Dubai Marina, Dubai",
                            CategoryId = 4,
                            Detail = "Elan Real Estate delighted to present Ciel Tower that means Sky in French, is in Dubai Marina one of the magnificent height of 360 meters and is a breathtaking building that will set a new global milestone as the world's tallest hotel upon completion. The architectural marvel is the newest landmark added to the world-famous skyline of the Marina. Designed by the award-winning London-based architect NORR, Ciel Tower features a stunning exterior, futuristic interiors and a spectacular glass observation deck that provides incredible 360-degree views of Dubai Marina, Palm Jumeirah and the Arab Gulf. ",
                            ImageUrl = "imagep12.jpg",
                            IsTrending = true,
                            Name = "Blue World",
                            Price = 650000.0,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("RealEstateApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "andrew@email.com",
                            Name = "Andrew",
                            Password = "And@1234",
                            Phone = "93524682"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@email.com",
                            Name = "Bob",
                            Password = "Bb@1234",
                            Phone = "93925611"
                        },
                        new
                        {
                            Id = 3,
                            Email = "john@email.com",
                            Name = "John",
                            Password = "Jn@1234",
                            Phone = "93624627"
                        },
                        new
                        {
                            Id = 4,
                            Email = "chris@email.com",
                            Name = "Chris",
                            Password = "Crs@1234",
                            Phone = "93304682"
                        });
                });

            modelBuilder.Entity("RealEstateApi.Models.Bookmark", b =>
                {
                    b.HasOne("RealEstateApi.Models.Property", "Property")
                        .WithMany("Bookmarks")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("RealEstateApi.Models.Property", b =>
                {
                    b.HasOne("RealEstateApi.Models.Category", "Category")
                        .WithMany("Properties")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateApi.Models.User", "User")
                        .WithMany("Properties")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RealEstateApi.Models.Category", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("RealEstateApi.Models.Property", b =>
                {
                    b.Navigation("Bookmarks");
                });

            modelBuilder.Entity("RealEstateApi.Models.User", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
