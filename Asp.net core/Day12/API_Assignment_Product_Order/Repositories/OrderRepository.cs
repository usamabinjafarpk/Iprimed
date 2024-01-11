using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void DeltOrder(int OrdId)
        {
            List<Order> _order = new List<Order>();
            List<Product> _Prod = productRepository.products;

        }

        public List<Order> GetAllOders()
        {
            throw new NotImplementedException();
        }

        public void OredrProd(int id, Order order, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
