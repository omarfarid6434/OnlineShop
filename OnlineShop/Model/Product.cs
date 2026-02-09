namespace OnlineShop.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public bool IsActive { get; set; }

        public string BranchId { get; set; }
        public int UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
