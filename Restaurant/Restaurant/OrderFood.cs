using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    abstract class OrderFood
    {
        //public string Food { get;set; }
        abstract public void Order();
        public void Price(string Food)
        {
            switch(Food)
            {
                case "Sushi":
                    Console.WriteLine("Price - 50$");
                    break;
                case "Pizza":
                    Console.WriteLine("Price - 33$");
                    break;
                case "Pasta":
                    Console.WriteLine("Price - 85$");
                    break;
                case "Salad":
                    Console.WriteLine("Price - 26$");
                    break;
            }
        }
    }
    enum FoodList
    {
        Sushi,
        Pizza,
        Pasta,
        Salad
    }
}
