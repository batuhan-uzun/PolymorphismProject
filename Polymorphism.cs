using PolymorphismProject;

BaseGeometricShape rectangle = new Rectangle(); // Created a Rectangle object of type BaseGeometripShape
rectangle.Width = 5;
rectangle.Height = 5;
Console.WriteLine(rectangle.CalculateArea()); // Rectangle area calculation method printed

BaseGeometricShape square = new Square(); // Created a Square object of type BaseGeometripShape
square.Width = 10;
square.Height = 10;
Console.WriteLine(square.CalculateArea()); // Square area calculation method printed

BaseGeometricShape triangle = new RighTriangle(); // Created a RightTriangle object of type BaseGeometripShape
triangle.Width = 5;
triangle.Height = 2;
Console.WriteLine(triangle.CalculateArea()); // Right Triangle area calculation method printed

