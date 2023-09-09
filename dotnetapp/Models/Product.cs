using System;

namespace dotnetapp.Models
{
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
public class ProductDbContext:dbContext
{
    public ProductDbContext(dbContextOptions<ProductDbContext> options):base(options)
    {

    }
    public DbSet<Product> Products {get;set;}
}
}