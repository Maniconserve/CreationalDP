namespace FactoryDP
{
	// Concrete Product 1 - PayPal Payment
	public class PayPalPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} via PayPal...");
		}
	}
}
