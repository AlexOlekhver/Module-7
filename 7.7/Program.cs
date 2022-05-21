using System;

namespace _7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            User Name = new User();
            Name.Greetings();
            
            Products products = new Products();
            
            Drinks drinks = new Drinks();
            
            Alcоhol alcоhol = new Alcоhol();
            alcоhol.Age = User.age;

        }
    }
    public class User
    {
        public string name;
        public static int age;

        public void Greetings()
        {
            Console.WriteLine("Our store greetings you,  {0}!!!", name);
        }
        public User()
        {
            Console.WriteLine("Please insert you name:");
            name = Console.ReadLine();
            Console.WriteLine("Please insert you age:");
            age = int.Parse(Console.ReadLine());
        }
    }
    class Order
    {
        public string[] OrderedList;
    }
    public abstract class Good
    {
        public string Description;
        public string Type;
    }
    public abstract class Goods
    {
        public string[] Good;

        public abstract string[] ChooseItem();
    }
    class Products: Goods
    {
        
        public override string[] ChooseItem()
        {
            int i;
            Console.WriteLine("Please insert number of product thich you want or tyoe 0 for cancel");
            if (i = 0)
            {
                
            }
            
            return ;
        }
    }
    class Drinks: Goods
    {
        public string[] NonAlcohol;

    }
    sealed class Alcоhol : Drinks
    {
        
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

    }

    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order1<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
    enum Product
        {
        banana,
        apple,
        potato,
        }
    enum Drink
    {
        banana_juice,
        apple_juice,
        water
    }
    enum AlcoholDrink
    {
        vodka,
        gin,
        whiskey
    }
}
