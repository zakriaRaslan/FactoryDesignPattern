using FactoryDesignPattern_Problem;

class Program
{
    public static void Main(string[] args)
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
                    meal.Appetizer = new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
                    break;
                case 2:
                    meal.Appetizer = new GreenSalad("Small", "70-80", 05.99m, new() { "Tomato", "Carrots", "Onion", "Cucumper" });
                    break;
                case 3:
                    meal.Appetizer = new ColeslawSalad("Small", "100-150", 07.99m, new() { "Red Cabbage", "Pepper", "Shredded Carrots", "Mayonnaise" });
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
                    meal.MainCourse = new Pizza("Large", "300-600", 14.99m, new() { "Olive", "Cheese", "Tomato", "Beef" });
                    break;
                case 5:
                    meal.MainCourse = new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" });
                    break;
                case 6:
                    meal.MainCourse = new Burger("Medium", "100-200", 16.99m, new() { "Meat", "Onion", "Cheese", "Special Sauce" });
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
                    meal.Dessert = new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
                    break;
                case 8:
                    meal.Dessert = new MilkShake("Small", "400-600", 08.99m, new() { "Milk", "Ice Cream", "Chocolate Syrup", "Fruit", "Caramel Sauce" });
                    break;
                case 9:
                    meal.Dessert = new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
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