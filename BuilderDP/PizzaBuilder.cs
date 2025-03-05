namespace BuilderDP
{
	// Abstract Builder (Defines the steps for building a pizza)
	public abstract class PizzaBuilder
	{
		protected Pizza pizza;

		public void CreateNewPizza() { pizza = new Pizza(); }

		public abstract void SetSize();
		public abstract void SetCrust();
		public abstract void SetToppings();
		public abstract void SetSauce();

		public Pizza GetPizza() { return pizza; }
	}
}
