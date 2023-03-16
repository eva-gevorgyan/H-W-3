using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Rest : OrderFood, IRest
    {
        //public string food = "Sushi";
        //public string Food { get { return food; }  set { food = value; } }
        public string Name { get; set; } = "BestRest";
        public string Location { get; set; } = "Las Vegas";
        public double Rating { get; set; } = 5.2;

        public void AboutRest()
        {
            Console.WriteLine($"Name - {Name}, Locatin - {Location}, Rating - {Rating}");
        }
        void IRest.SpecialOrder(string p, string w)
        {
            Console.WriteLine("Your special order is " + p + " and " + w);
        }
        public override void Order()
        {
            Console.WriteLine("You order will be ready in 25 min");
        }

    }
}
