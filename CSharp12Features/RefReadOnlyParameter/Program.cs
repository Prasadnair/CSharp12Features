// See https://aka.ms/new-console-template for more information
using RefReadOnlyParameter;

Console.WriteLine("Ref Readonly Parameter!");

int age = 42;
var example = new Example();
Console.WriteLine("Ref Parameter!");
example.MethodWtithoutRefReadOnlyParameter(ref age);
Console.WriteLine($"Age: {age}");

Console.WriteLine("Ref Readonly Parameter!");

example.MethodWithRefReadOnlyParameter(ref age);
Console.WriteLine($"Age: {age}");


