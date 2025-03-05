namespace PrototypeDP
{
	abstract class ShapePrototype
	{
		public string Type { get; set; }
		public string Color { get; set; }

		public abstract ShapePrototype Clone();

		public void Print()
		{
			Console.WriteLine($"Cloned Shape: {Type}, Color: {Color}");
		}
	}
}
