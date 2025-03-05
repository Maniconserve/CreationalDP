using PrototypeDP;

Console.WriteLine("BEFORE Prototype Pattern (Manual Copying)");
Shape shape1 = new Shape { Type = "Circle", Color = "Red" };
Shape shape2 = new Shape { Type = shape1.Type, Color = shape1.Color }; // Manual Copy
shape2.Print();

Console.WriteLine("AFTER Prototype Pattern (Using Cloning)");
Circle original = new Circle("Blue");
Circle cloned = (Circle)original.Clone(); // Prototype Pattern
cloned.Print();