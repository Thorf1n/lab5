

namespace Lab5
{
    internal class Store : ISearchable
    {

        private List<Product> Products;
        private List<User> Users;
        private List<Order> Orders;

        public Store()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Product> SearchByCriteria(string category, decimal minPrice, decimal maxPrice)
        {
            List<Product> result = new List<Product>();
            foreach (var product in Products)
            {
                if (product.Category == category && product.Price >= minPrice && product.Price <= maxPrice)
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}
