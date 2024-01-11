using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public interface IOrderRepository
    {
        public void OredrProd(int id, Order order, Product product);
        public List<Order> GetAllOders();
        public void DeltOrder(int OrdId);
    }
}
