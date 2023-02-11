using GeometryCalcs;

Console.WriteLine("Hello");

var figure = new Circle(5);
var figure2 = new Triangle(4, 5, 6);
var triangle = new Triangle(4.4, 5.2, 6.81175454637);

Console.WriteLine(figure.Area);
Console.WriteLine(figure2.Area);
Console.WriteLine(triangle.isRight());

//example for new figure
var square = new Square(5, 6);
Console.WriteLine(square.Area);
