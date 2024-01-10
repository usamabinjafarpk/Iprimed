using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetProductsByNameOrCategory(string name, string category);
        List<Product> GetProductsByCategory(string category);

    }
}
