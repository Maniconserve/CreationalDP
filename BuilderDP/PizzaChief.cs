namespace BuilderDP
{
	// Director (Ensures correct order of pizza construction)
	public class PizzaChef
	{
		public Pizza MakePizza(PizzaBuilder builder)
		{
			builder.CreateNewPizza();
			builder.SetSize();
			builder.SetCrust();
			builder.SetToppings();
			builder.SetSauce();
			return builder.GetPizza();
		}
	}
}
