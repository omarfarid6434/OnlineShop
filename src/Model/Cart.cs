namespace OnlineShop.Model
{
    public class Cart
    {
        public int CartId { get; set; }

        public string BranchId { get; set; }
        public int UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public ICollection<CartItem> Items { get; set; }
    }
}
