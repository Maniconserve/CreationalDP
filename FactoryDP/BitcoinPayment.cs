namespace FactoryDP
{
	//Concrete Product 3 - Bitcoin Payment
	public class BitcoinPayment : IPayment
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} via Bitcoin...");
		}
	}
}
