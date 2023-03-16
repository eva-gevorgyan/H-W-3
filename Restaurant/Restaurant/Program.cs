namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRest irest = new Rest();
            irest.AboutRest();
            Console.WriteLine();
            Console.Write("Special or Custom? ");
            string a = Console.ReadLine();
            if (a == "Special")
            {
                irest.SpecialOrder("Pasta", "Wine");
            }
            else
            {
                Console.WriteLine("Choose Sushi, Pizza, Pasta or Salad");
                string b = Console.ReadLine();
                OrderFood food = new Rest();
                food.Order();
                food.Price(b);
            }
        }
    }
}