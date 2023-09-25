namespace FactoryDesignPattern_Problem
{
    public interface IAppetizer : IDish
    {
    }

    public class ChickenSalad : Dish, IAppetizer
    {
        public ChickenSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }

        public void Serve()
        {
            Console.WriteLine($"ChickenSalad \n▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class GreenSalad : Dish, IAppetizer
    {
        public GreenSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }

        public void Serve()
        {
            Console.WriteLine($"GreenSalad \n▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class ColeslawSalad : Dish, IAppetizer
    {
        public ColeslawSalad(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }

        public void Serve()
        {
            Console.WriteLine($"ColeslawSalad \n▀▀▀▀▀▀▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
