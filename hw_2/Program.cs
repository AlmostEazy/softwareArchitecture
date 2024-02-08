using hw_2.Factory_Method;

Console.WriteLine("Factory Method");
Random random = new Random();
List<Sellers> sellers = [new FruitSeller(), new MeatSeller(), new VegetableSeller()];

for (int i = 0; i < 10; i += 1)
{
    Product product = sellers[Math.Abs((random.Next() % sellers.Count))].createProduct();
}