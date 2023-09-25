using SimpleFactoryDesignPattern;

class Program
{
    public static void Main(string[] data)
    {
        (IAppetizer Appetizer, IMainCourse MainCourse, IDessert Dessert) meal = new();

        int choice;

        Console.WriteLine("Appetizers");
        Console.WriteLine($" ├ [01] Chicken Salad");
        Console.WriteLine($" ├ [02] Green Salad");
        Console.WriteLine($" ├ [03] Coleslaw Salad");
        Console.WriteLine($" └ Any other key to skip");


        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    meal.Appetizer = DishFactory.CreateAppetizer("ChickenSalad");
                    break;
                case 2:
                    meal.Appetizer = DishFactory.CreateAppetizer("GreenSalad");
                    break;
                case 3:
                    meal.Appetizer = DishFactory.CreateAppetizer("ColeslawSalad");
                    break;
                default:
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Main Course");
        Console.WriteLine($" ├ [04] Pizza");
        Console.WriteLine($" ├ [05] Steak");
        Console.WriteLine($" ├ [06] Burger");
        Console.WriteLine($" └ Any other key to skip");

        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 4:
                    meal.MainCourse = DishFactory.CreateMainCourse("Pizza");
                    break;
                case 5:
                    meal.MainCourse = DishFactory.CreateMainCourse("Steak");
                    break;
                case 6:
                    meal.MainCourse = DishFactory.CreateMainCourse("Burger");
                    break;
                default:
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Desserts");
        Console.WriteLine($" ├ [07] Fruit Salad");
        Console.WriteLine($" ├ [8] MilkShake");
        Console.WriteLine($" ├ [9] IceCream");
        Console.WriteLine($" └ Any other key to skip");


        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 7:
                    meal.Dessert = DishFactory.CreateDessert("FruitSalad");
                    break;
                case 8:
                    meal.Dessert = DishFactory.CreateDessert("MilkShake");
                    break;
                case 9:
                    meal.Dessert = DishFactory.CreateDessert("IceCream");
                    break;
                default:
                    break;
            }
        }
        Console.Clear();

        meal.Appetizer?.Serve();
        meal.MainCourse?.Serve();
        meal.Dessert?.Serve();
    }
}