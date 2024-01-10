using API_Assignment_Product_Order.Models;
using API_Assignment_Product_Order.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Assignment_Product_Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            productRepository.AddProduct(product);
            return Ok(product);
        }
        [HttpGet("GetProductsByCategory")]
        public IActionResult GetProductsByCategory(string category)
        {
            return Ok(productRepository.GetProductsByCategory(category));
        }
        [HttpGet("GetProductsByNameOrCategory")]
        public IActionResult GetProductsByNameOrCategory(string category,string name)
        {
            return Ok(productRepository.GetProductsByNameOrCategory(name, category));
        }
        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
            return Ok("Deleted");
        }
    }
}
