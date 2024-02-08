namespace hw_2.Factory_Method
{
    public class FruitSeller : Sellers
    {
        public override Product createProduct()
        {
            return new Fruit();
        }
    }
}