using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
           return _dbContext.Products;
        }
        public bool AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.Savechanges();
            return true;
        }

        public bool DeleteProduct(int Id)
        {
            return false;
        }
    }
}