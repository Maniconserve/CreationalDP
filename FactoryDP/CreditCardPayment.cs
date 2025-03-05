namespace FactoryDP
{
	// Concrete Product 2 - Credit Card Payment
	public class CreditCardPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} via Credit Card...");
		}
	}

}
