// See https://aka.ms/new-console-template for more information
Console.WriteLine("Collection Expression");

//array initializtion using collection expression
int[] numbers = { 1, 2, 3, 4, 5 };

int[] number1 = { 1, 2, 3 };
int[] number2 = { 4, 5, 6 };
int[] number3 = { 7, 8, 9 };

int[] merge = [..number1, ..number2, ..number3];

//var cannot be used with collection expressions
//var digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

Console.WriteLine($"Merge: {string.Join(",", merge)}");
Console.ReadLine();
