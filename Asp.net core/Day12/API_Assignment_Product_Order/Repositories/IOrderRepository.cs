using API_Assignment_Product_Order.Models;

namespace API_Assignment_Product_Order.Repositories
{
    public interface IOrderRepository
    {
        string OrderProduct(Order order);
        List<Order> GetOrders();
        void DeleteOrder(int id);
    }
}
