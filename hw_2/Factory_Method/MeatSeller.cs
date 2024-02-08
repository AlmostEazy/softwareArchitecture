namespace hw_2.Factory_Method
{
    public class MeatSeller : Sellers
    {
        public override Product createProduct()
        {
            return new Meat();
        }
    }
}