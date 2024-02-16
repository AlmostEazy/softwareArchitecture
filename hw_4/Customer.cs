namespace hw_4
{
    public class Customer
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public IBank Bank { get; set; }
        public Customer(int id, IBank bank) {
            Products = new List<Product>();
            Id = id;
            Bank = bank;
        }

        public List<Product> searchProducts(IProductSeller productSeller)
        {
            return productSeller.getProducts();
        }

        public bool buyProduct(Product product, IProductSeller productSeller)
        {
            bool answer = productSeller.buyProduct(product, Bank);
            if (answer) { Products.Add(product); }
            return answer;
        }
    }
}