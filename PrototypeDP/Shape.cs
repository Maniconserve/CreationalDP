namespace PrototypeDP
{
	// BEFORE Prototype Pattern (Manual Copying)
	class Shape
	{
		public string Type { get; set; }
		public string Color { get; set; }

		public void Print()
		{
			Console.WriteLine($"Shape: {Type}, Color: {Color}");
		}
	}
}
