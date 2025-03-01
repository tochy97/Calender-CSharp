// See https://aka.ms/new-console-template for more information
using Calender;

Console.WriteLine("Hello, World!");

Day day = new Day();
Console.WriteLine("Today is " + day.name + ", " + day.index + " " + day.month + " " + day.year);

Console.ReadLine();