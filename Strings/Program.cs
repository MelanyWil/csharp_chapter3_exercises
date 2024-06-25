// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Strings!");

string suess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

string[] suessArray = suess.Split(".");
Console.WriteLine(string.Join(",", suessArray));