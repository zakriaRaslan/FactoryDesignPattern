namespace AbstractFactoryDesignPattern
{
    public abstract class DishFactory
    {
        public abstract IDish CreatDish();
    }

    public class ChickenSaladFactory : DishFactory
    {
        public override IAppetizer CreatDish()
        {
            return new ChickenSalad("Small", "350-450", 08.99m, new() { "Chicken", "Lettuce", "Tomatoes", "Cucumbers", "Salad dressing" });
        }
    }
    public class GreenSaladFactory : DishFactory
    {
        public override IAppetizer CreatDish()
        {
            return new GreenSalad("Small", "70-80", 05.99m, new() { "Tomato", "Carrots", "Onion", "Cucumper" });
        }
    }
    public class ColeslawSaladFactory : DishFactory
    {
        public override IAppetizer CreatDish()
        {
            return new ColeslawSalad("Small", "100-150", 07.99m, new() { "Red Cabbage", "Pepper", "Shredded Carrots", "Mayonnaise" });
        }
    }

    public class PizzaFactory : DishFactory
    {
        public override IMainCourse CreatDish()
        {
            return new Pizza("Large", "300-600", 14.99m, new() { "Olive", "Cheese", "Tomato", "Beef" });
        }
    }
    public class SteakFactory : DishFactory
    {
        public override IMainCourse CreatDish()
        {
            return new Steak("Medium", "500-700", 17.99m, new() { "Beef steak", "Salt", "Pepper" });
        }
    }
    public class BurgerFactory : DishFactory
    {
        public override IMainCourse CreatDish()
        {
            return new Burger("Medium", "100-200", 16.99m, new() { "Meat", "Onion", "Cheese", "Special Sauce" });
        }
    }

    public class FruitSaladFactory : DishFactory
    {
        public override IDessert CreatDish()
        {
            return new FruitSalad("Medium", "100-150", 07.99m, new() { "Apple", "Banana", "Orange", "Berries" });
        }
    }
    public class MilkShakeFactory : DishFactory
    {
        public override IDessert CreatDish()
        {
            return new MilkShake("Small", "400-600", 08.99m, new() { "Milk", "Ice Cream", "Chocolate Syrup", "Fruit", "Caramel Sauce" });
        }
    }
    public class IceCreamFactory : DishFactory
    {
        public override IDessert CreatDish()
        {
            return new IceCream("Small", "200-250", 06.99m, new() { "Milk", "Sugar", "Cream", "Egg yolks", "Vanilla extract" });
        }
    }
}

