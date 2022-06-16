using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Camisa Bonita",
                Price = new decimal(69.9),
                Description = "Camisa Legal",
                ImageUrl = "https://keydesign.vteximg.com.br/arquivos/ids/196162-638-638/Camiseta-Basica-Com-Bolso---Branca-638-638.jpg?v=637172072326670000",
                CategoryName = "T-Shirt"
            });
        }
    }
}
