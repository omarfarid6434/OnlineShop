namespace OnlineShop.Model
{
    public class OrderMain
    {

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; }

        public string BranchId { get; set; }
        public int UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public ICollection<OrderSub> Items { get; set; }
    }
}
