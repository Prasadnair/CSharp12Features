// See https://aka.ms/new-console-template for more information

 using circleType = (int X, int Y, int Radius);

var circle = new circleType(10, 10, 20);
//we can declare in the below way also
//circleType circle = (10, 10, 20);

Console.WriteLine($"X: {circle.X}, Y: {circle.Y}, Radius: {circle.Radius}");


