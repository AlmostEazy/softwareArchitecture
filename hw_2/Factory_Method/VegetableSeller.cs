namespace hw_2.Factory_Method
{
    public class VegetableSeller : Sellers
    {
        public override Product createProduct()
        {
            return new Vegetable();
        }
    }
}