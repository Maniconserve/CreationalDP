namespace BuilderDP
{
	// Product Class (The complex object being built)
	public class Pizza
	{
		public string Size { get; set; }
		public string Crust { get; set; }
		public string Toppings { get; set; }
		public string Sauce { get; set; }

		public void DisplayPizza()
		{
			Console.WriteLine($"Pizza Order: Size = {Size}, Crust = {Crust}, Toppings = {Toppings}, Sauce = {Sauce}");
		}
	}
}
