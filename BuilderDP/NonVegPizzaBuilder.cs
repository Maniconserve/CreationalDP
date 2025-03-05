namespace BuilderDP
{
	// Concrete Builder 2 (Builds a Non-Vegetarian Pizza)
	public class NonVegPizzaBuilder : PizzaBuilder
	{
		public override void SetSize() { pizza.Size = "Large"; }
		public override void SetCrust() { pizza.Crust = "Cheese Burst"; }
		public override void SetToppings() { pizza.Toppings = "Chicken, Pepperoni"; }
		public override void SetSauce() { pizza.Sauce = "Barbeque"; }
	}
}
