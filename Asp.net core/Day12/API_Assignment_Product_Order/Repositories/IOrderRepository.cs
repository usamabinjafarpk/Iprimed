using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public interface IOrderRepository
    {
        void Order(Order order);
        List<Order> GetOrders();
        void DeleteProduct(int ProductId);
    }
}
