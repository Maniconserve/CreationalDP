namespace BuilderDP
{
	class Program
	{
		static void Main(string[] args)
		{
			PizzaChef chef = new PizzaChef();

			// Order 1: Vegetarian Pizza
			PizzaBuilder vegPizzaBuilder = new VegPizzaBuilder();
			Pizza vegPizza = chef.MakePizza(vegPizzaBuilder);
			vegPizza.DisplayPizza();

			Console.WriteLine("------------------------");

			// Order 2: Non-Vegetarian Pizza
			PizzaBuilder nonVegPizzaBuilder = new NonVegPizzaBuilder();
			Pizza nonVegPizza = chef.MakePizza(nonVegPizzaBuilder);
			nonVegPizza.DisplayPizza();

			Console.ReadKey();
		}
	}
}