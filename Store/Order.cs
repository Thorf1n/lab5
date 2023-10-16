

namespace Lab5
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public string Status { get; set; }
    }
}
