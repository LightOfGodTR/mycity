using ECommercePlatform.Configurations;
using Microsoft.EntityFrameworkCore;
using ECommercePlatform.Models;
using System;

namespace ECommercePlatform.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Place> Places { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Reseller> Resellers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Yapılandırmaları uygulayın
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PlaceConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new ResellerConfiguration());
            modelBuilder.ApplyConfiguration(new VendorConfiguration());

            modelBuilder.Entity<Order>()
              .Property(o => o.OrderDate)
              .HasColumnType("timestamp with time zone");

            modelBuilder.Entity<Report>()
              .Property(r => r.GeneratedDate)
              .HasColumnType("timestamp with time zone");

            // Seed verilerini tanımlayın

            // **Product**
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Ürün 1",
                    Description = "Ürün 1 Açıklaması",
                    Price = 100m,
                    Stock = 50,
                    Category = "Elektronik"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Ürün 2",
                    Description = "Ürün 2 Açıklaması",
                    Price = 200m,
                    Stock = 30,
                    Category = "Ev Eşyası"
                }
            );

            // **Vendor**
            modelBuilder.Entity<Vendor>().HasData(
                new Vendor
                {
                    VendorId = 1,
                    Name = "Tedarikçi 1",
                    ContactName = "Ahmet",
                    Email = "ahmet@tedarikci1.com",
                    Phone = "0123456789",
                    Address = "Adres 1",
                    City = "İstanbul",
                    State = "İstanbul",
                    PostalCode = "34000",
                    Country = "Türkiye"
                },
                new Vendor
                {
                    VendorId = 2,
                    Name = "Tedarikçi 2",
                    ContactName = "Mehmet",
                    Email = "mehmet@tedarikci2.com",
                    Phone = "0123456788",
                    Address = "Adres 2",
                    City = "Ankara",
                    State = "Ankara",
                    PostalCode = "06000",
                    Country = "Türkiye"
                }
            );

            // **Reseller**
            modelBuilder.Entity<Reseller>().HasData(
                new Reseller
                {
                    ResellerId = 1,
                    Name = "Bayi 1",
                    ContactName = "Ayşe",
                    Email = "ayse@bayi1.com",
                    Phone = "0123456787",
                    Address = "Adres 3",
                    City = "İzmir",
                    State = "İzmir",
                    PostalCode = "35000",
                    Country = "Türkiye"
                },
                new Reseller
                {
                    ResellerId = 2,
                    Name = "Bayi 2",
                    ContactName = "Fatma",
                    Email = "fatma@bayi2.com",
                    Phone = "0123456786",
                    Address = "Adres 4",
                    City = "Bursa",
                    State = "Bursa",
                    PostalCode = "16000",
                    Country = "Türkiye"
                }
            );

            // **Place**
            modelBuilder.Entity<Place>().HasData(
                new Place
                {
                    PlaceId = 1,
                    Name = "Depo 1",
                    Address = "Depo Adresi 1",
                    City = "İstanbul",
                    State = "İstanbul",
                    PostalCode = "34000",
                    Country = "Türkiye",
                    Description = "Ana Depo"
                },
                new Place
                {
                    PlaceId = 2,
                    Name = "Mağaza 1",
                    Address = "Mağaza Adresi 1",
                    City = "Ankara",
                    State = "Ankara",
                    PostalCode = "06000",
                    Country = "Türkiye",
                    Description = "Merkez Mağaza"
                }
            );

            // **Cart**
            modelBuilder.Entity<Cart>().HasData(
                new Cart { CartId = 1, UserId = 1 },
                new Cart { CartId = 2, UserId = 2 }
            );

            // **CartItem**
            modelBuilder.Entity<CartItem>().HasData(
                new CartItem
                {
                    CartItemId = 1,
                    CartId = 1,
                    ProductId = 1,
                    Quantity = 2,
                    Price = 100m
                },
                new CartItem
                {
                    CartItemId = 2,
                    CartId = 1,
                    ProductId = 2,
                    Quantity = 1,
                    Price = 200m
                },
                new CartItem
                {
                    CartItemId = 3,
                    CartId = 2,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 100m
                }
            );

            // **Order**
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    UserId = 1,
                    OrderDate = DateTime.SpecifyKind(new DateTime(2023, 10, 1), DateTimeKind.Utc)
                },
                new Order
                {
                    OrderId = 2,
                    UserId = 2,
                    OrderDate = DateTime.SpecifyKind(new DateTime(2023, 9, 30), DateTimeKind.Utc)
                }
            );

            // **OrderItem**
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    OrderItemId = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 2,
                    Price = 100m
                },
                new OrderItem
                {
                    OrderItemId = 2,
                    OrderId = 1,
                    ProductId = 2,
                    Quantity = 1,
                    Price = 200m
                },
                new OrderItem
                {
                    OrderItemId = 3,
                    OrderId = 2,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 100m
                }
            );

            // **Report**
            modelBuilder.Entity<Report>().HasData(
                new Report
                {
                    ReportId = 1,
                    Title = "Satış Raporu",
                    GeneratedDate = new DateTime(2023, 10, 1, 0, 0, 0, DateTimeKind.Utc),
                    GeneratedBy = "Yönetici",
                    Content = "Rapor içeriği burada yer alacak."
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
