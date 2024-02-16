namespace hw_4.ProductSellers
{
    internal class FruitSeller : IProductSeller
    {
        public bool buyProduct(Product product, IBank bank)
        {
            bool answer = bank.buy(product.Price);
            return answer;
        }

        public List<Product> getProducts()
        {
            List<Product> result = new List<Product>();
            return result;
        }
    }
}