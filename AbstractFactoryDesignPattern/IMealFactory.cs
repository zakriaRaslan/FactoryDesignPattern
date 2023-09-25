namespace AbstractFactoryDesignPattern
{
    public interface IMealFactory
    {
        IAppetizer PrepareAppetize();
        IMainCourse PrepareMainCourse();
        IDessert PrepareDessert();
    }

    public class SpecialMealFactory : IMealFactory
    {
        public IAppetizer PrepareAppetize()
        {
            return new ColeslawSalad("Large", "200-300", 10.99m, new() { "Red Cabbage", "Pepper", "Shredded Carrots", "Mayonnaise" });
        }

        public IMainCourse PrepareMainCourse()
        {
            return new Burger("Large", "600-700", 24.99m, new() { "Meat", "Onion", "Cheese", "Special Sauce" });
        }

        public IDessert PrepareDessert()
        {
            return new MilkShake("Medium", "400-600", 09.99m, new() { "Milk", "Ice Cream", "Chocolate Syrup", "Fruit", "Caramel Sauce" });
        }
    }

    public class HappyMealFactory : IMealFactory
    {
        public IAppetizer PrepareAppetize()
        {
            return new ColeslawSalad("Small", "100-200", 10.99m, new() { "Red Cabbage", "Pepper", "Shredded Carrots", "Mayonnaise" });
        }

        public IMainCourse PrepareMainCourse()
        {
            return new Burger("Small", "200-300", 14.99m, new() { "Meat", "Onion", "Cheese", "Special Sauce" });
        }

        public IDessert PrepareDessert()
        {
            return new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
        }
    }
}
