// See https://aka.ms/new-console-template for more information

using TemplateMethod_1;

Console.WriteLine("Nescafe Coffee Preparation\n");
CoffeeTemplate coffee = new NescafeCoffee();
coffee.PrepareCoffee();
Console.WriteLine();
Console.WriteLine("Bru coffee preparation\n");
coffee = new BruCoffee();
coffee.PrepareCoffee();
Console.Read();