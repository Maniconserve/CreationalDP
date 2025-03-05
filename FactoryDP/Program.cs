using FactoryDP;

Console.WriteLine("Enter payment amount:");
decimal amount = Convert.ToDecimal(Console.ReadLine());

// Get the appropriate payment method using factory logic
IPayment paymentMethod = PaymentFactory.GetPaymentMethod(amount);

// Process the payment
paymentMethod.ProcessPayment(amount);

Console.ReadKey();