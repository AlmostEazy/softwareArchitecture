namespace hw_4
{
    public interface IProductSeller
    {
        public List<Product> getProducts();
        public bool buyProduct(Product product, IBank bank);
    }
}