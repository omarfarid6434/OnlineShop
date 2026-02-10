namespace OnlineShop.Model
{
    public class OrderSub
    {

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } 
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public OrderMain OrderMain { get; set; }
    }
}
