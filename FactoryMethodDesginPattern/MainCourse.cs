namespace FactoryMethodDesginPattern
{
    public interface IMainCourse : IDish
    {
    }
    public class Steak : Dish, IMainCourse
    {
        public Steak(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients) { }

        public void Serve()
        {
            Console.WriteLine($"Steak \n▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class Pizza : Dish, IMainCourse
    {
        public Pizza(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }
        public void Serve()
        {
            Console.WriteLine($"Pizza \n▀▀▀▀▀\n{ShowDetails()}");
        }
    }
    public class Burger : Dish, IMainCourse
    {
        public Burger(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }
        public void Serve()
        {
            Console.WriteLine($"Burger \n▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }

    public class Spagety : Dish, IMainCourse
    {
        public Spagety(string size, string calories, decimal price, List<string> ingredients) : base(size, calories, price, ingredients)
        { }
        public void Serve()
        {
            Console.WriteLine($"Spagety \n▀▀▀▀▀▀▀\n{ShowDetails()}");
        }
    }
}
