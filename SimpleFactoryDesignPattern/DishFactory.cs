namespace SimpleFactoryDesignPattern
{
    public class DishFactory
    {
        public static IAppetizer CreateAppetizer(string DishType)
        {
            return DishType switch
            {
                "ChickenSalad" => new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" }),
                "GreenSalad" => new GreenSalad("Small", "70-80", 05.99m, new() { "Tomato", "Carrots", "Onion", "Cucumper" }),
                "ColeslawSalad" => new ColeslawSalad("Small", "100-150", 07.99m, new() { "Red Cabbage", "Pepper", "Shredded Carrots", "Mayonnaise" }),
            };
        }

        public static IMainCourse CreateMainCourse(string DishType)
        {
            return DishType switch
            {
                "Pizza" => new Pizza("Large", "300-600", 14.99m, new() { "Olive", "Cheese", "Tomato", "Beef" }),
                "Steak" => new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" }),
                "Burger" => new Burger("Medium", "100-200", 16.99m, new() { "Meat", "Onion", "Cheese", "Special Sauce" }),
            };
        }

        public static IDessert CreateDessert(string DishType)
        {
            return DishType switch
            {
                "FruitSalad" => new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" }),
                "MilkShake" => new MilkShake("Small", "400-600", 08.99m, new() { "Milk", "Ice Cream", "Chocolate Syrup", "Fruit", "Caramel Sauce" }),
                "IceCream" => new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" }),
            };
        }
    }
}

