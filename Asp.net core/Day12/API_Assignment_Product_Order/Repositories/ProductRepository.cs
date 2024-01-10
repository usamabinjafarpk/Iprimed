using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            foreach (Product product in products)
            {
                if (product.Product_Id == id)
                {
                    products.Remove(product);
                }
            }
        }

        public List<Product> GetProductsByCategory(string category)
        {
            List<Product> res = new List<Product>();
            foreach (Product product in products)
            {
                if (category.Equals(product.Category))
                {
                    res.Add(product);
                }
            }
            return res;
        }

        public List<Product> GetProductsByNameOrCategory(string name, string category)
        {
            List <Product> res = new List<Product>();
            foreach (Product product in products)
            {
                if (category.Equals(product.Category) || name.Equals(product.Product_Name))
                {
                    res.Add(product);
                }
            }
            return res;
        }

        public void UpdateProduct(Product product)
        {
            foreach(var item in products)
            {
                if(item.Product_Id == product.Product_Id)
                {
                    item.Product_Name = product.Product_Name;
                    item.Price = product.Price;
                    item.Category = product.Category;
                    item.Stock = product.Stock;
                }
            }
        }
    }
}
