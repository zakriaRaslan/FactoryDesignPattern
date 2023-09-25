namespace FactoryMethodDesginPattern
{
    public interface IDessert : IDish
    {
    }

    public class MilkShake : Dish, IDessert
    {
        public MilkShake(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"MilkShake \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class FruitSalad : Dish, IDessert
    {
        public FruitSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"FruitSalad \n▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class IceCream : Dish, IDessert
    {
        public IceCream(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }
        public void Serve()
        {
            Console.WriteLine($"Ice Cream \n▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
