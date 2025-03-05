namespace BuilderDP
{
	// Concrete Builder 1 (Builds a Vegetarian Pizza)
	public class VegPizzaBuilder : PizzaBuilder
	{
		public override void SetSize() { pizza.Size = "Medium"; }
		public override void SetCrust() { pizza.Crust = "Thin Crust"; }
		public override void SetToppings() { pizza.Toppings = "Capsicum, Olives, Paneer"; }
		public override void SetSauce() { pizza.Sauce = "Tomato Basil"; }
	}
}
