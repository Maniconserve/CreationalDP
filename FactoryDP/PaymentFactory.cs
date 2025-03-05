namespace FactoryDP
{
	// Factory Class (Applies Business Logic)
	public class PaymentFactory
	{
		public static IPayment GetPaymentMethod(decimal amount)
		{
			if (amount < 100)
				return new PayPalPayment();
			else if (amount >= 100 && amount <= 1000)
				return new CreditCardPayment();
			else
				return new BitcoinPayment();
		}
	}
}
