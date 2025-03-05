namespace PrototypeDP
{
	class Circle : ShapePrototype
	{
		public Circle(string color)
		{
			Type = "Circle";
			Color = color;
		}

		public override ShapePrototype Clone()
		{
			//memberwiseclone creates a shallow copy(for refrence types in the cloning object, new memory is not allocated),
			//to achieve a deep copy we have to customize the logic in this method
			return (ShapePrototype)MemberwiseClone();
		}
	}
}
