namespace API_Assignment_Product_Order.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId {  get; set; }
        public DateTime OrderDate { get; set; }
        public int Qty {  get; set; }
        public int amount {  get; set; }
    }
}
