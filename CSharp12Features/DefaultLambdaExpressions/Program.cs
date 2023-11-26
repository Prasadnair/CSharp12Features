// See https://aka.ms/new-console-template for more information
Console.WriteLine("Default Lambda Parameters!");

var lambdaDefaultParameter = (int age = 38) => Console.WriteLine($"Age: {age}");

lambdaDefaultParameter();

lambdaDefaultParameter(50);

Console.ReadLine();

