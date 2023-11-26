// See https://aka.ms/new-console-template for more information
using PrimaryConstructor;

Console.WriteLine("Primary Constructor");

Person person=new("John", 42);
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
Console.ReadLine();