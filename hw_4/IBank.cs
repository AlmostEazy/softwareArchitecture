namespace hw_4
{
    public interface IBank
    {
        public bool buy(double price);
        public bool IsAuthorization(Customer customer);
    }
}