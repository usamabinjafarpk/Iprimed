using API_Assignment_Product_Order.Models;
using API_Assignment_Product_Order.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Assignment_Product_Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderRepository orderRepository;

        public OrderController(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }


        [HttpPost("AddOrder")]
        public IActionResult AddOrder(Order order)
        {
            return StatusCode(200, orderRepository.OrderProduct(order));
        }

        [HttpGet("GetOrders")]
        public IActionResult GEtOrder()
        {
            return StatusCode(200, orderRepository.GetOrders());
        }

        [HttpDelete("RemoveOrder/{id}")]
        public IActionResult DeleteOrder(int id)
        {
            orderRepository.DeleteOrder(id);
            return StatusCode(200, "Order deleted");
        }
    }
}
